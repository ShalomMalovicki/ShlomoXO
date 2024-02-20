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
        private char[] board = { 'x', ' ', 'o', ' ', ' ', ' ', 'x', ' ', ' ' };
        #endregion Private Fields

      
        #region Properties   
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
        #endregion Properties
    }
}
