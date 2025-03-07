namespace PokemonDex
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }

        private void picPokemon_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnPikachu_Click(object sender, EventArgs e)
        {
            try
            {
                Pikachu pikachu = new Pikachu();

                lblName.Text = "Name: " + pikachu.GetName();
                lblHP.Text = "HP: " + pikachu.GetHP();
                lblAttack.Text = "Attack: " + pikachu.GetAttack();
                lblDefense.Text = "Defense: " + pikachu.GetDefense();
                lblSpeed.Text = "Speed: " + pikachu.GetSpeed();
                lblSpecies.Text = "Species: " + pikachu.GetSpecies();
                lblType.Text = "Type: " + pikachu.GetPokemonType().ToString();

                // โหลดและแสดงรูปภาพ
                picPokemon.Image = pikachu.GetImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSnorlax_Click(object sender, EventArgs e)
        {
            try
            {
                Snorlax snorlax = new Snorlax();

                lblName.Text = "Name: " + snorlax.GetName();
                lblHP.Text = "HP: " + snorlax.GetHP();
                lblAttack.Text = "Attack: " + snorlax.GetAttack();
                lblDefense.Text = "Defense: " + snorlax.GetDefense();
                lblSpeed.Text = "Speed: " + snorlax.GetSpeed();
                lblSpecies.Text = "Species: " + snorlax.GetSpecies();
                lblType.Text = "Type: " + snorlax.GetPokemonType().ToString();

                // โหลดและแสดงรูป Snorlax
                picPokemon.Image = snorlax.GetImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGengar_Click(object sender, EventArgs e)
        {
            try
            {
                Gengar gengar = new Gengar();

                lblName.Text = "Name: " + gengar.GetName();
                lblHP.Text = "HP: " + gengar.GetHP();
                lblAttack.Text = "Attack: " + gengar.GetAttack();
                lblDefense.Text = "Defense: " + gengar.GetDefense();
                lblSpeed.Text = "Speed: " + gengar.GetSpeed();
                lblSpecies.Text = "Species: " + gengar.GetSpecies();
                lblType.Text = "Type: " + gengar.GetPokemonType().ToString();

                // โหลดและแสดงรูป Gengar
                picPokemon.Image = gengar.GetImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBlissey_Click(object sender, EventArgs e)
        {
            try
            {
                Blissey blissey = new Blissey();

                lblName.Text = "Name: " + blissey.GetName();
                lblHP.Text = "HP: " + blissey.GetHP();
                lblAttack.Text = "Attack: " + blissey.GetAttack();
                lblDefense.Text = "Defense: " + blissey.GetDefense();
                lblSpeed.Text = "Speed: " + blissey.GetSpeed();
                lblSpecies.Text = "Species: " + blissey.GetSpecies();
                lblType.Text = "Type: " + blissey.GetPokemonType().ToString();

                // โหลดและแสดงรูป Blissey
                picPokemon.Image = blissey.GetImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSwirlix_Click(object sender, EventArgs e)
        {
            try
            {
                Swirlix swirlix = new Swirlix();

                lblName.Text = "Name: " + swirlix.GetName();
                lblHP.Text = "HP: " + swirlix.GetHP();
                lblAttack.Text = "Attack: " + swirlix.GetAttack();
                lblDefense.Text = "Defense: " + swirlix.GetDefense();
                lblSpeed.Text = "Speed: " + swirlix.GetSpeed();
                lblSpecies.Text = "Species: " + swirlix.GetSpecies();
                lblType.Text = "Type: " + swirlix.GetPokemonType().ToString();

                // โหลดและแสดงรูป Swirlix
                picPokemon.Image = swirlix.GetImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnTinkaton_Click(object sender, EventArgs e)
        {
            try
            {
                Tinkaton tinkaton = new Tinkaton();

                lblName.Text = "Name: " + tinkaton.GetName();
                lblHP.Text = "HP: " + tinkaton.GetHP();
                lblAttack.Text = "Attack: " + tinkaton.GetAttack();
                lblDefense.Text = "Defense: " + tinkaton.GetDefense();
                lblSpeed.Text = "Speed: " + tinkaton.GetSpeed();
                lblSpecies.Text = "Species: " + tinkaton.GetSpecies();
                lblType.Text = "Type: " + tinkaton.GetPokemonType().ToString();

                // โหลดและแสดงรูป Tinkaton
                picPokemon.Image = tinkaton.GetImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCharizard_Click(object sender, EventArgs e)
        {
            try
            {
                Charizard charizard = new Charizard();

                lblName.Text = "Name: " + charizard.GetName();
                lblHP.Text = "HP: " + charizard.GetHP();
                lblAttack.Text = "Attack: " + charizard.GetAttack();
                lblDefense.Text = "Defense: " + charizard.GetDefense();
                lblSpeed.Text = "Speed: " + charizard.GetSpeed();
                lblSpecies.Text = "Species: " + charizard.GetSpecies();
                lblType.Text = "Type: " + charizard.GetPokemonType().ToString();

                // โหลดและแสดงรูป Charizard
                picPokemon.Image = charizard.GetImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSpecial_Click(object sender, EventArgs e)
        {
            try
            {
                Special special = new Special();

                lblName.Text = "Name: " + special.GetName();
                lblHP.Text = "HP: " + special.GetHP();
                lblAttack.Text = "Attack: " + special.GetAttack();
                lblDefense.Text = "Defense: " + special.GetDefense();
                lblSpeed.Text = "Speed: " + special.GetSpeed();
                lblSpecies.Text = "Species: " + special.GetSpecies();
                lblType.Text = "Type: " + special.GetPokemonType().ToString();

                // โหลดและแสดงรูป Special Pokémon
                picPokemon.Image = special.GetImage();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
