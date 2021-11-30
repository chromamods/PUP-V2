
namespace PUP_V2
{
    partial class PUPGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCharge = new System.Windows.Forms.Button();
            this.buttonDiagnostics = new System.Windows.Forms.Button();
            this.buttonTransport = new System.Windows.Forms.Button();
            this.buttonEmergency = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSatComm = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 116);
            this.label1.TabIndex = 0;
            this.label1.Text = "PUP-ER Control";
            // 
            // buttonCharge
            // 
            this.buttonCharge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCharge.Font = new System.Drawing.Font("Nirmala UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCharge.Location = new System.Drawing.Point(116, 66);
            this.buttonCharge.Name = "buttonCharge";
            this.buttonCharge.Size = new System.Drawing.Size(139, 70);
            this.buttonCharge.TabIndex = 1;
            this.buttonCharge.Text = "Charge";
            this.buttonCharge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCharge.UseVisualStyleBackColor = true;
            this.buttonCharge.Click += new System.EventHandler(this.buttonCharge_Click);
            // 
            // buttonDiagnostics
            // 
            this.buttonDiagnostics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiagnostics.Font = new System.Drawing.Font("Nirmala UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiagnostics.Location = new System.Drawing.Point(116, 522);
            this.buttonDiagnostics.Name = "buttonDiagnostics";
            this.buttonDiagnostics.Size = new System.Drawing.Size(206, 70);
            this.buttonDiagnostics.TabIndex = 4;
            this.buttonDiagnostics.Text = "Diagnostics";
            this.buttonDiagnostics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDiagnostics.UseVisualStyleBackColor = true;
            this.buttonDiagnostics.Click += new System.EventHandler(this.buttonDiagnostics_Click);
            // 
            // buttonTransport
            // 
            this.buttonTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransport.Font = new System.Drawing.Font("Nirmala UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTransport.Location = new System.Drawing.Point(116, 370);
            this.buttonTransport.Name = "buttonTransport";
            this.buttonTransport.Size = new System.Drawing.Size(278, 70);
            this.buttonTransport.TabIndex = 3;
            this.buttonTransport.Text = "Transport Mode";
            this.buttonTransport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTransport.UseVisualStyleBackColor = true;
            this.buttonTransport.Click += new System.EventHandler(this.buttonTransport_Click);
            // 
            // buttonEmergency
            // 
            this.buttonEmergency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmergency.Font = new System.Drawing.Font("Nirmala UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEmergency.Location = new System.Drawing.Point(116, 674);
            this.buttonEmergency.Name = "buttonEmergency";
            this.buttonEmergency.Size = new System.Drawing.Size(197, 70);
            this.buttonEmergency.TabIndex = 5;
            this.buttonEmergency.Text = "Emergency";
            this.buttonEmergency.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmergency.UseVisualStyleBackColor = true;
            this.buttonEmergency.Click += new System.EventHandler(this.buttonEmergency_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEmergency);
            this.groupBox1.Controls.Add(this.buttonSatComm);
            this.groupBox1.Controls.Add(this.buttonTransport);
            this.groupBox1.Controls.Add(this.buttonDiagnostics);
            this.groupBox1.Controls.Add(this.buttonCharge);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(1280, 957);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonSatComm
            // 
            this.buttonSatComm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSatComm.Font = new System.Drawing.Font("Nirmala UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSatComm.Location = new System.Drawing.Point(116, 218);
            this.buttonSatComm.Name = "buttonSatComm";
            this.buttonSatComm.Size = new System.Drawing.Size(398, 70);
            this.buttonSatComm.TabIndex = 2;
            this.buttonSatComm.Text = "Satellite Communication";
            this.buttonSatComm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSatComm.UseVisualStyleBackColor = true;
            this.buttonSatComm.Click += new System.EventHandler(this.buttonSatComm_Click);
            // 
            // PUPGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1280, 1080);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PUPGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PUP GUI";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCharge;
        private System.Windows.Forms.Button buttonDiagnostics;
        private System.Windows.Forms.Button buttonTransport;
        private System.Windows.Forms.Button buttonEmergency;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSatComm;
    }
}

