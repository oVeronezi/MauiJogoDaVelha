namespace MauiJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
        int jogadas = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button botao_pressionado = (Button)sender;

            botao_pressionado.IsEnabled = false;
            jogadas++;


            if (vez == "X")
            {
                botao_pressionado.Text = "X";
                vez = "O";
            }
            else
            {
                botao_pressionado.Text = "O";
                vez = "X";
            }

            // =========================
            // VITÓRIAS DO X
            // =========================

            // Linha 1
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlertAsync("Parabéns! 🎉🏆", "O X Ganhou!", "Ok");
                zerar();
                return;
            }

            // Linha 2
            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                DisplayAlertAsync("Parabéns! 🎉🏆", "O X Ganhou!", "Ok");
                zerar();
                return;
            }

            // Linha 3
            if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                DisplayAlertAsync("Parabéns! 🎉🏆", "O X Ganhou!", "Ok");
                zerar();
                return;
            }

            // Coluna 1
            if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                DisplayAlertAsync("Parabéns! 🎉🏆", "O X Ganhou!", "Ok");
                zerar();
                return;
            }

            // Coluna 2
            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                DisplayAlertAsync("Parabéns! 🎉🏆", "O X Ganhou!", "Ok");
                zerar();
                return;
            }

            // Coluna 3
            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                DisplayAlertAsync("Parabéns! 🎉🏆", "O X Ganhou!", "Ok");
                zerar();
                return;
            }

            // Diagonal \
            if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                DisplayAlertAsync("Parabéns! 🎉🏆", "O X Ganhou!", "Ok");
                zerar();
                return;
            }

            // Diagonal /
            if (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X")
            {
                DisplayAlertAsync("Parabéns! 🎉🏆", "O X Ganhou!", "Ok");
                zerar();
                return;
            }


            // =========================
            // VITÓRIAS DO O
            // =========================

            // Linha 1
            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlertAsync("Parabéns! 🎉🏆", "O 'O' Ganhou!", "Ok");
                zerar();
                return;
            }

            // Linha 2
            if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                DisplayAlertAsync("Parabéns! 🎉🏆", "O 'O' Ganhou!", "Ok");
                zerar();
                return;
            }

            // Linha 3
            if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                DisplayAlertAsync("Parabéns! 🎉🏆", "O 'O' Ganhou!", "Ok");
                zerar();
                return;
            }

            // Coluna 1
            if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                DisplayAlertAsync("Parabéns! 🎉🏆", "O 'O' Ganhou!", "Ok");
                zerar();
                return;
            }

            // Coluna 2
            if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                DisplayAlertAsync("Parabéns! 🎉🏆", "O 'O' Ganhou!", "Ok");
                zerar();
                return;
            }

            // Coluna 3
            if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                DisplayAlertAsync("Parabéns! 🎉🏆", "O 'O' Ganhou!", "Ok");
                zerar();
                return;
            }

            // Diagonal \
            if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                DisplayAlertAsync("Parabéns! 🎉🏆", "O 'O' Ganhou!", "Ok");
                zerar();
                return;
            }

            // Diagonal /
            if (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O")
            {
                DisplayAlertAsync("Parabéns! 🎉🏆", "O 'O' Ganhou!", "Ok");
                zerar();
                return;
            }

            // Empate
            if (jogadas == 9)
            {
                DisplayAlertAsync("O Jogo deu Velha!🤝", "Empate!🤝", "Empataro!🤝");
            }

            void zerar()
            {
                btn10.Text = "";
                btn11.Text = "";
                btn12.Text = "";

                btn20.Text = "";
                btn21.Text = "";
                btn22.Text = "";

                btn30.Text = "";
                btn31.Text = "";
                btn32.Text = "";

                jogadas = 0;

                btn10.IsEnabled = true;
                btn11.IsEnabled = true;
                btn12.IsEnabled = true;
                
                btn20.IsEnabled = true;
                btn21.IsEnabled = true;
                btn22.IsEnabled = true;
                
                btn30.IsEnabled = true;
                btn31.IsEnabled = true;
                btn32.IsEnabled = true;

            }
        }
    }
}
