
namespace client
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtBoxIP = new JMaterialTextbox.JMaterialTextbox();
            this.txtBoxPort = new JMaterialTextbox.JMaterialTextbox();
            this.btnScreen = new client.RoundButton();
            this.btnChat = new client.RoundButton();
            this.btnConnect = new client.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(503, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 27);
            this.panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::client.Properties.Resources.Love_icon_social_media_vector_PNG;
            this.pictureBox1.Location = new System.Drawing.Point(43, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtBoxIP
            // 
            this.txtBoxIP.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxIP.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBoxIP.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBoxIP.ForeColors = System.Drawing.Color.Black;
            this.txtBoxIP.HintText = null;
            this.txtBoxIP.IsPassword = false;
            this.txtBoxIP.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxIP.LineThickness = 2;
            this.txtBoxIP.Location = new System.Drawing.Point(149, 70);
            this.txtBoxIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxIP.MaxLength = 32767;
            this.txtBoxIP.Name = "txtBoxIP";
            this.txtBoxIP.OnFocusedColor = System.Drawing.Color.Black;
            this.txtBoxIP.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtBoxIP.ReadOnly = false;
            this.txtBoxIP.Size = new System.Drawing.Size(136, 20);
            this.txtBoxIP.TabIndex = 14;
            this.txtBoxIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxIP.TextName = "Ex: 192.168.1.0";
            // 
            // txtBoxPort
            // 
            this.txtBoxPort.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxPort.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBoxPort.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBoxPort.ForeColors = System.Drawing.Color.Black;
            this.txtBoxPort.HintText = null;
            this.txtBoxPort.IsPassword = false;
            this.txtBoxPort.LineBackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtBoxPort.LineThickness = 2;
            this.txtBoxPort.Location = new System.Drawing.Point(374, 70);
            this.txtBoxPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxPort.MaxLength = 32767;
            this.txtBoxPort.Name = "txtBoxPort";
            this.txtBoxPort.OnFocusedColor = System.Drawing.Color.Black;
            this.txtBoxPort.OnFocusedTextColor = System.Drawing.Color.Black;
            this.txtBoxPort.ReadOnly = false;
            this.txtBoxPort.Size = new System.Drawing.Size(117, 20);
            this.txtBoxPort.TabIndex = 15;
            this.txtBoxPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBoxPort.TextName = "Ex: 5000";
            // 
            // btnScreen
            // 
            this.btnScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnScreen.FlatAppearance.BorderSize = 0;
            this.btnScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreen.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScreen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnScreen.Location = new System.Drawing.Point(452, 153);
            this.btnScreen.Name = "btnScreen";
            this.btnScreen.Size = new System.Drawing.Size(96, 93);
            this.btnScreen.TabIndex = 8;
            this.btnScreen.Text = "Screen";
            this.btnScreen.UseVisualStyleBackColor = false;
            this.btnScreen.Click += new System.EventHandler(this.roundButton3_Click);
            // 
            // btnChat
            // 
            this.btnChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChat.FlatAppearance.BorderSize = 0;
            this.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChat.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChat.Location = new System.Drawing.Point(313, 153);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(96, 93);
            this.btnChat.TabIndex = 7;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = false;
            this.btnChat.Click += new System.EventHandler(this.roundButton2_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConnect.Location = new System.Drawing.Point(173, 153);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 93);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.roundButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(560, 294);
            this.Controls.Add(this.txtBoxPort);
            this.Controls.Add(this.txtBoxIP);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnScreen);
            this.Controls.Add(this.btnChat);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private RoundButton btnConnect;
        private RoundButton btnChat;
        private RoundButton btnScreen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private JMaterialTextbox.JMaterialTextbox txtBoxIP;
        private JMaterialTextbox.JMaterialTextbox txtBoxPort;
    }
}

