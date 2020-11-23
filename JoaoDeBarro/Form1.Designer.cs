namespace JoaoDeBarro
{
    partial class frmMain
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
            this.btnConnection = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(309, 172);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(214, 34);
            this.btnConnection.TabIndex = 0;
            this.btnConnection.Text = "Testar Conexão";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 294);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnConnection);
            this.Name = "frmMain";
            this.Text = "João de Barro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Label lblResult;
    }
}

