using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShlomoXO
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        #region Private Fields 
        private string playerX;
        private string playerO;
        private char[] board = new char[10];
        private bool isPlayerXTurn = true;
        private string turnText;
        #endregion Private Fields

        public MainViewModel()
        {
            //PlayerX = "Player X";
            //PlayerO = "Player O";
            
            //for (int i = 0; i < 10; i++)
            //{
            //    Board[i] = ' ';
            //}
            PropertyChanged += In_PropertyChanged;
        }
        #region PropertyChanged
        private void In_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "PlayerX":
                    if (playerO != null)
                    {
                        TurnText =  $"Player {(isPlayerXTurn ? playerX : playerO)} Turn";
                    }
                    
                    break;

                case "PlayerO":
                    if (playerX != null)
                    {
                        TurnText = $"Player {(isPlayerXTurn ? playerX : playerO)} Turn";
                    }

                    break;

                case "IsPlayerXTurn":
                    if (playerO != null && playerX != null) 
                    {
                        TurnText = $"Player {(isPlayerXTurn ? playerX : playerO)} Turn";
                    }

                    break;
            }
        }
        #endregion PropertyChanged

        #region Properties  
        public bool IsPlayerXTurn
        {
            get => isPlayerXTurn;
            set
            {
                isPlayerXTurn = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsPlayerXTurn)));
            }
        }
        public string PlayerX
        {
            get => playerX;
            set
            {
                playerX = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PlayerX)));
            }
        }
        public string PlayerO
        {
            get => playerO;
            set
            {
                playerO = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(PlayerO)));
            }
        }
        public char[] Board
        {
            get => board;
            set
            {
                board = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Board)));
            }
        }

        public string TurnText
        {
            get => turnText;
            set
            {
                turnText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TurnText)));
            }
        }       
        #endregion Properties
    }
}
