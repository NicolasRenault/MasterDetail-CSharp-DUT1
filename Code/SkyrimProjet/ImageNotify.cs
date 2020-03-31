using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyrimProjet
{
    public class ImageNotify : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string info)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(info));
        }

        private string srcImage;
        public string SrcImage
        {
            get { return srcImage; }
            internal set
            {
                srcImage = value;
                OnPropertyChanged("SrcImage");
            }
        }
    }
}
