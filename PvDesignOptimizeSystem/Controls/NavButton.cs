using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace PvDesignOptimizeSystem.Controls
{
    class NavButton : Button
    {
        private Color defaultBackColor = Color.FromArgb(222, 222, 222);
        private Boolean isActive = false;

        public NavButton()
            : base()
        {
            this.BackColor = defaultBackColor;
        }

        #region
        public void setActive(bool isActive)
        {
            this.BackColor = Color.FromArgb(100, 100, 100);
            this.isActive = isActive;
        }
        #endregion

        #region OverrideMethods
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            this.BackColor = Color.FromArgb(100,100,100);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            if (!isActive)
            {
                this.BackColor = defaultBackColor;
            }
        }
        #endregion
    }
}
