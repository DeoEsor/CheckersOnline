using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Models.Checkers;

namespace CheckersControls
{
    /// <summary>
    /// Логика взаимодействия для Desk.xaml
    /// </summary>
    public partial class Desk : UserControl
    {
        public Board Board { get; set; }
        
        public IEnumerable<char> Numbers => "87654321";
        public IEnumerable<char> Letters => "ABCDEFGH";
        
        public Desk()
        {
            InitializeComponent();
        }
    }
}
