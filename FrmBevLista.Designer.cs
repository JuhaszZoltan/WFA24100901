namespace WFA24100901
{
    partial class FrmBevLista
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txbUjTetel = new TextBox();
            btnHozzaadas = new Button();
            btnOsszesTorlese = new Button();
            btnKijeloltTorlese = new Button();
            lsbTetelek = new ListBox();
            SuspendLayout();
            // 
            // txbUjTetel
            // 
            txbUjTetel.Location = new Point(12, 27);
            txbUjTetel.Name = "txbUjTetel";
            txbUjTetel.PlaceholderText = "írd be az új tétel nevét ide...";
            txbUjTetel.Size = new Size(386, 32);
            txbUjTetel.TabIndex = 0;
            // 
            // btnHozzaadas
            // 
            btnHozzaadas.Enabled = false;
            btnHozzaadas.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnHozzaadas.Location = new Point(243, 89);
            btnHozzaadas.Name = "btnHozzaadas";
            btnHozzaadas.Size = new Size(155, 47);
            btnHozzaadas.TabIndex = 1;
            btnHozzaadas.Text = "Hozzáad";
            btnHozzaadas.UseVisualStyleBackColor = true;
            // 
            // btnOsszesTorlese
            // 
            btnOsszesTorlese.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnOsszesTorlese.Location = new Point(243, 244);
            btnOsszesTorlese.Name = "btnOsszesTorlese";
            btnOsszesTorlese.Size = new Size(155, 96);
            btnOsszesTorlese.TabIndex = 1;
            btnOsszesTorlese.Text = "Összes törlése";
            btnOsszesTorlese.UseVisualStyleBackColor = true;
            // 
            // btnKijeloltTorlese
            // 
            btnKijeloltTorlese.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnKijeloltTorlese.Location = new Point(243, 142);
            btnKijeloltTorlese.Name = "btnKijeloltTorlese";
            btnKijeloltTorlese.Size = new Size(155, 96);
            btnKijeloltTorlese.TabIndex = 1;
            btnKijeloltTorlese.Text = "Kijelölt törlése";
            btnKijeloltTorlese.UseVisualStyleBackColor = true;
            // 
            // lsbTetelek
            // 
            lsbTetelek.FormattingEnabled = true;
            lsbTetelek.ItemHeight = 25;
            lsbTetelek.Items.AddRange(new object[] { "Alma", "Körte", "Banán" });
            lsbTetelek.Location = new Point(12, 89);
            lsbTetelek.Name = "lsbTetelek";
            lsbTetelek.SelectionMode = SelectionMode.MultiExtended;
            lsbTetelek.Size = new Size(225, 454);
            lsbTetelek.TabIndex = 2;
            // 
            // FrmBevLista
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 555);
            Controls.Add(lsbTetelek);
            Controls.Add(btnKijeloltTorlese);
            Controls.Add(btnOsszesTorlese);
            Controls.Add(btnHozzaadas);
            Controls.Add(txbUjTetel);
            Font = new Font("Segoe UI", 14F);
            Margin = new Padding(5);
            Name = "FrmBevLista";
            Text = "Bevásárlólista";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbUjTetel;
        private Button btnHozzaadas;
        private Button btnOsszesTorlese;
        private Button btnKijeloltTorlese;
        private ListBox lsbTetelek;
    }
}
