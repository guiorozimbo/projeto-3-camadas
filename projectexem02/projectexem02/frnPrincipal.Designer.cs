
namespace projectexem02
{
    partial class frnPrincipal
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
            this.btnOpenProduct = new System.Windows.Forms.Button();
            this.btnOpenCadClient = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenProduct
            // 
            this.btnOpenProduct.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOpenProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenProduct.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenProduct.Location = new System.Drawing.Point(213, 118);
            this.btnOpenProduct.Name = "btnOpenProduct";
            this.btnOpenProduct.Size = new System.Drawing.Size(128, 23);
            this.btnOpenProduct.TabIndex = 3;
            this.btnOpenProduct.Text = "Cadastrar Produto";
            this.btnOpenProduct.UseVisualStyleBackColor = false;
            this.btnOpenProduct.Click += new System.EventHandler(this.btnOpenProduct_Click);
            // 
            // btnOpenCadClient
            // 
            this.btnOpenCadClient.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOpenCadClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenCadClient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOpenCadClient.Location = new System.Drawing.Point(213, 71);
            this.btnOpenCadClient.Name = "btnOpenCadClient";
            this.btnOpenCadClient.Size = new System.Drawing.Size(128, 23);
            this.btnOpenCadClient.TabIndex = 2;
            this.btnOpenCadClient.Text = "Cadastrar Cliente";
            this.btnOpenCadClient.UseVisualStyleBackColor = false;
            this.btnOpenCadClient.Click += new System.EventHandler(this.btnOpenCadClient_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Crimson;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(213, 162);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Fechar";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frnPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 232);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOpenProduct);
            this.Controls.Add(this.btnOpenCadClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frnPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frnPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenProduct;
        private System.Windows.Forms.Button btnOpenCadClient;
        private System.Windows.Forms.Button btnExit;
    }
}