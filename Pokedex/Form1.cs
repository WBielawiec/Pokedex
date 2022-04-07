using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Console_Pokedex;
using System.IO;
using System.Runtime.InteropServices;


namespace Pokedex
{
    public partial class Pokedex : Form
    {
        string json;
        List<Pokemon> pokemons;
        List<Moves> moves;
        List<Items> items;
        int pokemonIndex = 0, moveIndex = 0, firstItemIndex = 0, secondItemIndex = 1, thirdItemIndex = 2;
        string startupPath;
        Random rand = new Random();


        internal static class NativeWinAPI
        {
            internal static readonly int GWL_EXSTYLE = -20;
            internal static readonly int WS_EX_COMPOSITED = 0x02000000;

            [DllImport("user32")]
            internal static extern int GetWindowLong(IntPtr hWnd, int nIndex);

            [DllImport("user32")]
            internal static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        }

        public Pokedex()
        {
            InitializeComponent();

            int style = NativeWinAPI.GetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE);
            style |= NativeWinAPI.WS_EX_COMPOSITED;
            NativeWinAPI.SetWindowLong(this.Handle, NativeWinAPI.GWL_EXSTYLE, style);
        }

        //////////////////////////////////////////////////////////////
        ////////////////  Form load     //////////////////////////////
        //////////////////////////////////////////////////////////////

        private void Form1_Load(object sender, EventArgs e)
        {
            startupPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName);
            mainMenuPanel.BringToFront();
            json = File.ReadAllText(startupPath + "\\dane\\pokemon.json");
            pokemons = JsonConvert.DeserializeObject<List<Pokemon>>(json);
            json = File.ReadAllText(startupPath + "\\dane\\moves.json");
            moves = JsonConvert.DeserializeObject<List<Moves>>(json);
            json = File.ReadAllText(startupPath + "\\dane\\items.json");
            items = JsonConvert.DeserializeObject<List<Items>>(json);

            for (int i = 0; i < PokemonList.listaPokemonow.Count(); i++) {
                if (i + 1 < 10)
                {
                    String item = "00" + (i + 1) + "     " + PokemonList.listaPokemonow[i];
                    pokemonList.Items.Add(item);
                }
                else if (i + 1 >= 10 && i + 1 < 100)
                {
                    String item = "0" + (i + 1) + "     " + PokemonList.listaPokemonow[i]; ;
                    pokemonList.Items.Add(item);
                }
                else
                {
                    String item = "" + (i + 1) + "      " + PokemonList.listaPokemonow[i]; ;
                    pokemonList.Items.Add(item);
                }
            }
        }

        //////////////////////////////////////////////////////////////
        ////////////////  Main menu panel   //////////////////////////
        //////////////////////////////////////////////////////////////

        private void pokemonButton_Click(object sender, EventArgs e)
        {
            mainMenuPanel.Hide();
            pokemonPanel.Show();
            pokemonPanel.BringToFront();
            pokemonIndex = 0;
            pokemonList.SelectedIndex = 0;
            showPokemon();
        }

        private void pokemonButton_MouseEnter(object sender, EventArgs e)
        {
            pokemonButton.ForeColor = Color.FromArgb(200, 240, 77, 103);
        }

        private void pokemonButton_MouseLeave(object sender, EventArgs e)
        {
            pokemonButton.ForeColor = Color.Black;
        }

        private void movesButton_Click(object sender, EventArgs e)
        {
            mainMenuPanel.Hide();
            movesPanel.Show();
            movesPanel.BringToFront();

            for (int i = 0; i < moves.Count(); i++)
            {
                ListViewItem move = new ListViewItem(moves[i].id.ToString());
                move.SubItems.Add(moves[i].name);
                move.SubItems.Add(moves[i].type);
                move.SubItems.Add(moves[i].category);
                move.SubItems.Add(moves[i].pp.ToString());

                if (moves[i].power == null)
                {
                    move.SubItems.Add("-");
                }
                else {
                    move.SubItems.Add(moves[i].power.ToString());
                }

                if (moves[i].accuracy == null)
                {
                    move.SubItems.Add(" -");
                }
                else
                {
                    move.SubItems.Add(moves[i].accuracy.ToString() + "%");
                }

                movesList.Items.Add(move);
            }

            foreach (ListViewItem item in movesList.Items) {
                if (item.Index % 2 != 0)
                {
                    item.BackColor = Color.LightGray;
                }
            }

            showMove();
        }

        private void movesButton_MouseEnter(object sender, EventArgs e)
        {
            movesButton.ForeColor = Color.FromArgb(200, 240, 77, 103);
        }

        private void movesButton_MouseLeave(object sender, EventArgs e)
        {
            movesButton.ForeColor = Color.Black;
        }

        private void itemButton_Click(object sender, EventArgs e)
        {
            mainMenuPanel.Hide();
            itemsPanel.Show();
            itemsPanel.BringToFront();

            showItems();
        }

        private void itemButton_MouseEnter(object sender, EventArgs e)
        {
            itemButton.ForeColor = Color.FromArgb(200, 240, 77, 103);
        }

        private void itemButton_MouseLeave(object sender, EventArgs e)
        {
            itemButton.ForeColor = Color.Black;
        }

        private void gamesButton_Click(object sender, EventArgs e)
        {
            mainMenuPanel.Hide();
            gamesPanel.Show();
            gamesPanel.BringToFront();
        }

        private void gamesButton_MouseEnter(object sender, EventArgs e)
        {
            gamesButton.ForeColor = Color.FromArgb(200, 240, 77, 103);
        }

        private void gamesButton_MouseLeave(object sender, EventArgs e)
        {
            gamesButton.ForeColor = Color.Black;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        //////////////////////////////////////////////////////////////
        ////////////////  Pokemon panel //////////////////////////////
        //////////////////////////////////////////////////////////////
        private void pokemonMainMenuButtonM_Click(object sender, EventArgs e)
        {
            pokemonPanel.Hide();
            mainMenuPanel.Show();
            mainMenuPanel.BringToFront();
        }

        private void pokemonList_SelectedIndexChanged(object sender, EventArgs e)
        {
            pokemonIndex = pokemonList.SelectedIndex;
            showPokemon();
        }

        private void showPokemon()
        {
            string fileName;

            if (pokemonIndex + 1 < 10)
            {
                fileName = "00" + (pokemonIndex + 1) + ".png";
            }
            else if (pokemonIndex + 1 >= 10 && pokemonIndex + 1 < 100)
            {
                fileName = "0" + (pokemonIndex + 1) + ".png";
            }
            else
            {
                fileName = (pokemonIndex + 1) + ".png";
            }

            Image image = Image.FromFile(startupPath + "\\dane\\pokemonImages\\" + fileName);
            pokemonImage.Image = image;

            string typeConcat = "Type: ";
            foreach (string element in pokemons[pokemonIndex].type)
            {
                typeConcat += element + ", ";
            }

            typeLabel.Text = typeConcat;
            atkLabel.Text = "ATK: " + pokemons[pokemonIndex].@base.Attack.ToString();
            defLabel.Text = "DEF: " + pokemons[pokemonIndex].@base.Defense.ToString();
            spdLabel.Text = "SPD: " + pokemons[pokemonIndex].@base.Speed.ToString();
            hpLabel.Text = "HP:  " + pokemons[pokemonIndex].@base.HP.ToString();
            spatkLabel.Text = "SP.ATK: " + pokemons[pokemonIndex].@base.SpAttack.ToString();
            spdefLabel.Text = "SP.DEF: " + pokemons[pokemonIndex].@base.SpDefense.ToString();
            weightLabel.Text = "Weight: " + pokemons[pokemonIndex].profile.weight;
            heigthLabel.Text = "Heigth: " + pokemons[pokemonIndex].profile.height;

            try
            {
                previousLabel.Text = "Previous: " + (PokemonList.listaPokemonow[Convert.ToInt32(pokemons[pokemonIndex].evolution.prev[0]) - 1] + " at ") + pokemons[pokemonIndex].evolution.prev[1];
            }
            catch (System.NullReferenceException e)
            {
                previousLabel.Text = "Previous: " + ("-----");
            }
            catch (System.IndexOutOfRangeException e)
            {
                previousLabel.Text = "Previous: " + ("-----");
            }

            try
            {
                nextLabel.Text = "Next: " + (PokemonList.listaPokemonow[Convert.ToInt32(pokemons[pokemonIndex].evolution.next[0][0]) - 1] + " at ") + pokemons[pokemonIndex].evolution.next[0][1];
            }
            catch (System.NullReferenceException e)
            {
                nextLabel.Text = "Next: " + ("-----");
            }
            catch (System.IndexOutOfRangeException e)
            {
                nextLabel.Text = "Next: " + ("-----");
            }

            descriptionTextLabel.Text = pokemons[pokemonIndex].description;

        }

        private void previousPokemonButton_Click(object sender, EventArgs e)
        {
            if (pokemonIndex == 0)
            {
                pokemonIndex = pokemons.Count() - 1;
                pokemonList.SelectedIndex = pokemons.Count() - 1;
                showPokemon();
            }
            else
            {
                pokemonIndex--;
                pokemonList.SelectedIndex--;
                showPokemon();
            }
        }

        private void nextPokemonButton_Click(object sender, EventArgs e)
        {
            if (pokemonIndex == pokemons.Count() - 1)
            {
                pokemonIndex = 0;
                pokemonList.SelectedIndex = 0;
                showPokemon();
            }
            else
            {
                pokemonIndex++;
                pokemonList.SelectedIndex++;
                showPokemon();
            }
        }


        //////////////////////////////////////////////////////////////
        ////////////////  Moves panel ////////////////////////////////
        //////////////////////////////////////////////////////////////

        private void moveMainMenuButton_Click(object sender, EventArgs e)
        {
            movesPanel.Hide();
            mainMenuPanel.Show();
            mainMenuPanel.BringToFront();
        }


        private void movesList_Click(object sender, EventArgs e)
        {
            moveIndex = movesList.FocusedItem.Index;
            showMove();
        }

        private void movesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (movesList.SelectedIndices.Count > 0)
            {
                moveIndex = movesList.SelectedIndices[0];
            }
            showMove();
        }

        private void previousMoveButton_Click(object sender, EventArgs e)
        {
            if (moveIndex == 0)
            {
                moveIndex = moves.Count() - 1;
                movesList.Select();
                movesList.Items[moveIndex].Selected = true;
                movesList.Items[moveIndex].EnsureVisible();
                showMove();
            }
            else
            {
                moveIndex--;
                movesList.Items[moveIndex].Selected = true;
                movesList.Items[moveIndex].EnsureVisible();
                showMove();
            }
        }



        private void nextMoveButton_Click(object sender, EventArgs e)
        {
            if (moveIndex == moves.Count() - 1)
            {
                moveIndex = 0;
                movesList.Items[moveIndex].Selected = true;
                movesList.Items[moveIndex].EnsureVisible();
                showMove();
            }
            else
            {
                moveIndex++;
                movesList.Items[moveIndex].Selected = true;
                movesList.Items[moveIndex].EnsureVisible();
                showMove();
            }
        }

        private void showMove()
        {
            moveDescriptionLabel.Text = moves[moveIndex].description;
        }


        //////////////////////////////////////////////////////////////
        ////////////////  Items panel ////////////////////////////////
        //////////////////////////////////////////////////////////////

        private void itemMainMenuButton_Click(object sender, EventArgs e)
        {
            itemsPanel.Hide();
            mainMenuPanel.Show();
            mainMenuPanel.BringToFront();
        }



        private void previousItemButton_Click(object sender, EventArgs e)
        {
            if (firstItemIndex == 0)
            {
                firstItemIndex = items.Count() - 1;
                secondItemIndex--;
                thirdItemIndex--;
                showItems();
            }
            else if (secondItemIndex == 0)
            {
                firstItemIndex--;
                secondItemIndex = items.Count() - 1;
                thirdItemIndex--;
                showItems();
            } else if (thirdItemIndex == 0) {
                firstItemIndex--;
                secondItemIndex--; 
                thirdItemIndex = items.Count() - 1;
                showItems();
            }
            else
            {
                firstItemIndex--;
                secondItemIndex--;
                thirdItemIndex--;
                showItems();
            }
        }



        private void nextItemButton_Click(object sender, EventArgs e)
        {
            if (firstItemIndex == items.Count -1)
            {
                firstItemIndex = 0;
                secondItemIndex++;
                thirdItemIndex++;
                showItems();
            }
            else if (secondItemIndex == items.Count - 1)
            {
                firstItemIndex++;
                secondItemIndex = 0;
                thirdItemIndex++;
                showItems();
            }
            else if (thirdItemIndex == items.Count - 1)
            {
                firstItemIndex++;
                secondItemIndex++;
                thirdItemIndex = 0;
                showItems();
            }
            else
            {
                firstItemIndex++;
                secondItemIndex++;
                thirdItemIndex++;
                showItems();
            }
        }



        private void searchItemButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (string.Equals(items[i].name, itemSearchTextBox.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    if (i == 0)
                    {
                        firstItemIndex = items.Count - 1;
                        secondItemIndex = i;
                        thirdItemIndex = i + 1;
                    }
                    else if (i == items.Count - 1)
                    {
                        firstItemIndex = i - 1;
                        secondItemIndex = i;
                        thirdItemIndex = 0;
                    }
                    else
                    {
                        firstItemIndex = i - 1;
                        secondItemIndex = i;
                        thirdItemIndex = i + 1;
                    }
                    showItems();
                    itemSearchTextBox.Text = "";
                    break;
                }
            }
        }

        private void itemSearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (string.Equals(items[i].name, itemSearchTextBox.Text, StringComparison.CurrentCultureIgnoreCase))
                    {
                        if (i == 0)
                        {
                            firstItemIndex = items.Count - 1;
                            secondItemIndex = i;
                            thirdItemIndex = i + 1;
                        }
                        else if (i == items.Count - 1)
                        {
                            firstItemIndex = i - 1;
                            secondItemIndex = i;
                            thirdItemIndex = 0;
                        }
                        else
                        {
                            firstItemIndex = i - 1;
                            secondItemIndex = i;
                            thirdItemIndex = i + 1;
                        }
                        showItems();
                        itemSearchTextBox.Text = "";
                        break;
                    }
                }
            }
        }

        private void showItems() {

            string fileName1, fileName2, fileName3;

           fileName1 = items[firstItemIndex].id + ".png";
           fileName2 = items[secondItemIndex].id + ".png";
           fileName3 = items[thirdItemIndex].id + ".png";

            Image image1 = Image.FromFile(startupPath + "\\dane\\itemsImages\\" + fileName1);
            Image image2 = Image.FromFile(startupPath + "\\dane\\itemsImages\\" + fileName2);
            Image image3 = Image.FromFile(startupPath + "\\dane\\itemsImages\\" + fileName3);

            firstItemPicture.BackgroundImage = image1;
            secondItemPicture.BackgroundImage = image2;
            thirdItemPicture.BackgroundImage = image3;

            firstItemNameLabel.Text = items[firstItemIndex].name;
            secondItemNameLabel.Text = items[secondItemIndex].name;
            thirdItemNameLabel.Text = items[thirdItemIndex].name;

            firstItemDescriptionLabel.Text = items[firstItemIndex].description;
            secondItemDescriptionLabel.Text = items[secondItemIndex].description;
            thirdItemDescriptionLabel.Text = items[thirdItemIndex].description;

        }

        //////////////////////////////////////////////////////////////
        ////////////////  Games panel ////////////////////////////////
        //////////////////////////////////////////////////////////////

        private void gamesMainMenuButton_Click(object sender, EventArgs e)
        {
            gamesPanel.Hide();
            mainMenuPanel.Show();
            mainMenuPanel.BringToFront();
        }

        private void quizButton_Click(object sender, EventArgs e)
        {
            gamesPanel.Hide();
            answerButton.Hide();
            answerTextBox.Hide();
            answerButton.Hide();
            skipButton.Hide();
            quizPanel.Show();
            quizPanel.BringToFront();
            
        }

        private void memoButton_Click(object sender, EventArgs e)
        {

        }

        //////////////////////////////////////////////////////////////
        ////////////////  Quiz Panel  ////////////////////////////////
        //////////////////////////////////////////////////////////////

        string correctAns;
        int pointCounter = 0;
        List<int> pokemonRepeat = new List<int>();
        int count =0;
        int randomNumber;


        private void quizBackButton_Click(object sender, EventArgs e)
        {
            quizPanel.Hide();
            gamesPanel.Show();
            gamesPanel.BringToFront();
            resetGame();
        }

        private void quizMainMEnuButton_Click(object sender, EventArgs e)
        {
            quizPanel.Hide();
            mainMenuPanel.Show();
            mainMenuPanel.BringToFront();
            resetGame();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            easyButton.Hide();
            hardButton.Hide();

            easyMode();
        }

        private void easyButton_MouseEnter(object sender, EventArgs e)
        {
            easyButton.ForeColor = Color.Pink;
        }

        private void easyButton_MouseLeave(object sender, EventArgs e)
        {
            easyButton.ForeColor = Color.Black;
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            easyButton.Hide();
            hardButton.Hide();
            answerButton.Show();
            answerTextBox.Show();

            hardMode();
        }

        private void hardButton_MouseEnter(object sender, EventArgs e)
        {
            hardButton.ForeColor = Color.Pink;
        }

        private void hardButton_MouseLeave(object sender, EventArgs e)
        {
            hardButton.ForeColor = Color.Black;
        }

        private void easyMode() {

            string[] options = new string[4];

            if (count < 10)
            {
                    List<int> pokemonIndex = new List<int>();

                    for (int j = 0; j < pokemons.Count(); j++)
                    { //dodanie indexów poków do listy
                        pokemonIndex.Add(j);
                    }

                    for (int j = 0; j < pokemonRepeat.Count(); j++)
                    { //usunięcie z listy indexów poków, które już wystąpiły
                        pokemonIndex.Remove(pokemonRepeat.ElementAt(j));
                    }

                    int?[] optionRepeat = new int?[4];

                    for (int j = 0; j < 4; j++) //4 niepowtarzające się opcje
                    {
                        randomNumber = rand.Next(pokemonIndex.Count);
                        optionRepeat[j] = pokemonIndex.ElementAt(randomNumber);
                        pokemonIndex.RemoveAt(randomNumber);
                    }

                    randomNumber = rand.Next(4); //wylosowanie poprawnej odpowiedzi

                    pokemonRepeat.Add(optionRepeat[randomNumber] ?? 0);

                    options[0] = PokemonList.listaPokemonow[optionRepeat[0] ?? 0];
                    options[1] = PokemonList.listaPokemonow[optionRepeat[1] ?? 0];
                    options[2] = PokemonList.listaPokemonow[optionRepeat[2] ?? 0];
                    options[3] = PokemonList.listaPokemonow[optionRepeat[3] ?? 0];

                    correctAns = PokemonList.listaPokemonow[optionRepeat[randomNumber] ?? 0];

                    string fileName;

                    if ((optionRepeat[randomNumber] ?? 0) + 1 < 10)
                    {
                        fileName = "00" + ((optionRepeat[randomNumber] ?? 0) + 1) + ".png";
                    }
                    else if ((optionRepeat[randomNumber] ?? 0) + 1 >= 10 && (optionRepeat[randomNumber] ?? 0) + 1 < 100)
                    {
                        fileName = "0" + ((optionRepeat[randomNumber] ?? 0) + 1) + ".png";
                    }
                    else
                    {
                        fileName = ((optionRepeat[randomNumber] ?? 0) + 1) + ".png";
                    }

                    Image image = Image.FromFile(startupPath + "\\dane\\pokemonImages\\" + fileName);
                    quizImage.Image = image;

                    ans1Label.Text = options[0];
                    ans2Label.Text = options[1];
                    ans3Label.Text = options[2];
                    ans4Label.Text = options[3];
                    scoreLabel.Text = "SCORE: " + pointCounter.ToString();
            }
            else 
            {
                showSummary();
                resetGame();
            }   
        }

        private void hardMode() {
            int randomPokemon;
            if (count < 10)
            {

                if (count == 0)
                {
                    pokemonRepeat = new List<int>();

                    for (int j = 0; j < pokemons.Count; j++)
                    { //dodanie indexów poków do listy
                        pokemonRepeat.Add(j);
                    }
                }

                randomNumber = rand.Next(pokemonRepeat.Count);
                randomPokemon = pokemonRepeat.ElementAt(randomNumber);
                pokemonRepeat.RemoveAt(randomNumber);
                 
                string fileName;

                if (randomPokemon + 1 < 10)
                {
                    fileName = "00" + (randomPokemon + 1) + ".png";
                }
                else if (randomPokemon + 1 >= 10 && (randomPokemon + 1 < 100))
                {
                    fileName = "0" + (randomPokemon + 1) + ".png";
                }
                else
                {
                    fileName = (randomPokemon + 1) + ".png";
                }

                Image image = Image.FromFile(startupPath + "\\dane\\pokemonImages\\" + fileName);
                quizImage.Image = image;

                correctAns = PokemonList.listaPokemonow[randomPokemon];
                scoreLabel.Text = "SCORE: " + pointCounter.ToString();

            }
            else {
                showSummary();
                resetGame();
            }
        }

        private void resetGame() {
            pointCounter = 0;
            scoreLabel.Text = "";
            pokemonRepeat.Clear();
            count = 0;
            ans1Label.Text = "";
            ans2Label.Text = "";
            ans3Label.Text = "";
            ans4Label.Text = "";
            answerLabel.Text = "";
            quizImage.Image = null;

            answerTextBox.Hide();
            answerButton.Hide();

            easyButton.Show();
            hardButton.Show();
        }

        private void showSummary() {
            summaryPanel.Visible = true;
            summaryLabel.Text = "Your Score: " + pointCounter.ToString();
        }

        private void summaryBackButton_Click(object sender, EventArgs e)
        {
            summaryPanel.Visible = false;
            summaryPanel.Hide();
            quizPanel.BringToFront();
        }

        private void summaryMainMenuButton_Click(object sender, EventArgs e)
        {
            summaryPanel.Visible = false;
            quizPanel.Hide();
            mainMenuPanel.Show();
            mainMenuPanel.BringToFront();
        }

        private void ans1Label_Click(object sender, EventArgs e)
        {
            if (string.Equals(ans1Label.Text, correctAns, StringComparison.CurrentCultureIgnoreCase)) {
                pointCounter++;
            }
            count++;
            easyMode();
        }
        private void ans1Label_MouseEnter(object sender, EventArgs e)
        {
            ans1Label.ForeColor = Color.Pink;
        }

        private void ans1Label_MouseLeave(object sender, EventArgs e)
        {
            ans1Label.ForeColor = Color.Black;
        }

        private void ans2Label_Click(object sender, EventArgs e)
        {
            if (string.Equals(ans2Label.Text, correctAns, StringComparison.CurrentCultureIgnoreCase)) {
                pointCounter++;
            }
            count++;
            easyMode();
        }

        private void ans2Label_MouseEnter(object sender, EventArgs e)
        {
            ans2Label.ForeColor = Color.Pink;
        }

        private void ans2Label_MouseLeave(object sender, EventArgs e)
        {
            ans2Label.ForeColor = Color.Black;
        }

        private void ans3Label_Click(object sender, EventArgs e)
        {
            if (string.Equals(ans3Label.Text, correctAns, StringComparison.CurrentCultureIgnoreCase)) {
                pointCounter++;
            }
            count++;
            easyMode();
        }

        private void ans3Label_MouseEnter(object sender, EventArgs e)
        {
            ans3Label.ForeColor = Color.Pink;
        }

        private void ans3Label_MouseLeave(object sender, EventArgs e)
        {
            ans3Label.ForeColor = Color.Black;
        }

        private void ans4Label_Click(object sender, EventArgs e)
        {
            if (string.Equals(ans4Label.Text, correctAns, StringComparison.CurrentCultureIgnoreCase)) {
                pointCounter++;
            }
            count++;
            easyMode();
        }

        private void ans4Label_MouseEnter(object sender, EventArgs e)
        {
            ans4Label.ForeColor = Color.Pink;
        }

        private void ans4Label_MouseLeave(object sender, EventArgs e)
        {
            ans4Label.ForeColor = Color.Black;
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            if (string.Equals(answerTextBox.Text, correctAns, StringComparison.CurrentCultureIgnoreCase))
            {
                pointCounter++;
                count++;
                answerLabel.Text = "";
                answerTextBox.Text = "";
                skipButton.Hide();
                hardMode();
            }
            else
            {
                answerLabel.Text = "Wrong answer, try again :)";
                skipButton.Show();
            }
        }

        private void answerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) {
                if (string.Equals(answerTextBox.Text, correctAns, StringComparison.CurrentCultureIgnoreCase))
                {
                    pointCounter++;
                    count++;
                    answerLabel.Text = "";
                    answerTextBox.Text = "";
                    skipButton.Hide();
                    hardMode();
                }
                else {
                    answerLabel.Text = "Wrong answer, try again :)";
                    skipButton.Show();
                } 
            }
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            count++;
            answerLabel.Text = "";
            answerTextBox.Text = "";
            skipButton.Hide();
            hardMode();
        }

    }
}
