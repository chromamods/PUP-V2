
namespace PUP_V2
{
    partial class TransportMode
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
            this.buttonEndTransport = new System.Windows.Forms.Button();
            this.buttonReady = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEndTransport
            // 
            this.buttonEndTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEndTransport.Font = new System.Drawing.Font("Nirmala UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEndTransport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonEndTransport.Location = new System.Drawing.Point(463, 410);
            this.buttonEndTransport.Name = "buttonEndTransport";
            this.buttonEndTransport.Size = new System.Drawing.Size(361, 70);
            this.buttonEndTransport.TabIndex = 30;
            this.buttonEndTransport.Text = "End Transport Mode";
            this.buttonEndTransport.UseVisualStyleBackColor = true;
            this.buttonEndTransport.Click += new System.EventHandler(this.buttonEndTransport_Click);
            // 
            // buttonReady
            // 
            this.buttonReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReady.Font = new System.Drawing.Font("Nirmala UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReady.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonReady.Location = new System.Drawing.Point(463, 258);
            this.buttonReady.Name = "buttonReady";
            this.buttonReady.Size = new System.Drawing.Size(361, 70);
            this.buttonReady.TabIndex = 27;
            this.buttonReady.Text = "Ready for Transport";
            this.buttonReady.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(515, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 46);
            this.label1.TabIndex = 26;
            this.label1.Text = "Transport Mode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TransportMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1280, 908);
            this.Controls.Add(this.buttonEndTransport);
            this.Controls.Add(this.buttonReady);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TransportMode";
            this.Text = "TransportMode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEndTransport;
        private System.Windows.Forms.Button buttonReady;
        private System.Windows.Forms.Label label1;
    }
}