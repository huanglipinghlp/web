namespace Sy5
{
    partial class mainRight
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevComponents.DotNetBar.Keyboard.VirtualKeyboardColorTable virtualKeyboardColorTable2 = new DevComponents.DotNetBar.Keyboard.VirtualKeyboardColorTable();
            DevComponents.DotNetBar.Keyboard.FlatStyleRenderer flatStyleRenderer2 = new DevComponents.DotNetBar.Keyboard.FlatStyleRenderer();
            this.keyboardControl1 = new DevComponents.DotNetBar.Keyboard.KeyboardControl();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // keyboardControl1
            // 
            virtualKeyboardColorTable2.BackgroundColor = System.Drawing.Color.Black;
            virtualKeyboardColorTable2.DarkKeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(28)))), ((int)(((byte)(33)))));
            virtualKeyboardColorTable2.DownKeysColor = System.Drawing.Color.White;
            virtualKeyboardColorTable2.DownTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            virtualKeyboardColorTable2.KeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(47)))), ((int)(((byte)(55)))));
            virtualKeyboardColorTable2.LightKeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(68)))), ((int)(((byte)(76)))));
            virtualKeyboardColorTable2.PressedKeysColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(161)))), ((int)(((byte)(81)))));
            virtualKeyboardColorTable2.TextColor = System.Drawing.Color.White;
            virtualKeyboardColorTable2.ToggleTextColor = System.Drawing.Color.Green;
            virtualKeyboardColorTable2.TopBarTextColor = System.Drawing.Color.White;
            this.keyboardControl1.ColorTable = virtualKeyboardColorTable2;
            this.keyboardControl1.Location = new System.Drawing.Point(36, 42);
            this.keyboardControl1.Name = "keyboardControl1";
            flatStyleRenderer2.ColorTable = virtualKeyboardColorTable2;
            flatStyleRenderer2.ForceAntiAlias = false;
            this.keyboardControl1.Renderer = flatStyleRenderer2;
            this.keyboardControl1.Size = new System.Drawing.Size(615, 182);
            this.keyboardControl1.TabIndex = 0;
            this.keyboardControl1.Text = "keyboardControl1";
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Location = new System.Drawing.Point(305, 261);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(75, 23);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 2;
            this.buttonX1.Text = "退出";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // mainRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 318);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.keyboardControl1);
            this.Name = "mainRight";
            this.Text = "mainRight";
            this.Load += new System.EventHandler(this.mainRight_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Keyboard.KeyboardControl keyboardControl1;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}