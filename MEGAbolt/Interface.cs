using System.Windows.Forms;
using OpenMetaverse;

namespace MEGAbolt
{
    public abstract class Interface
    {
        public string Name;
        public string Description;
        public GridClient Client;
        public TabPage TabPage;

        public abstract void Initialize();

        public abstract void Paint(object sender, PaintEventArgs e);

        /// <summary>
        /// When set to true, think will be called.
        /// </summary>
        public bool Active;
    }
}
