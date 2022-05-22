using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatApplication.Contacts
{
    public partial class ContactItem : UserControl
    {
        public ContactItem()
        {
            InitializeComponent();
        }

        #region Properties

        private string _imgUrl;
        private string _name;
        private string _lastSeen;

        [Category("Contacts Card")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        [Category("Contacts Card")]
        public string LastSeen
        {
            get { return _lastSeen; }
            set { _lastSeen = value; }
        }

        [Category("Contacts Card")]
        public string ImgUrl
        {
            get { return _imgUrl; }
            set { _imgUrl = value; }
        }
        #endregion

    }
}
