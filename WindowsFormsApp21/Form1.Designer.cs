namespace WindowsFormsApp21
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.skorlabel1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.A = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.BackColor = System.Drawing.Color.LightBlue;
            this.btnCheckAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckAnswer.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheckAnswer.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnCheckAnswer.Location = new System.Drawing.Point(650, 350);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(202, 91);
            this.btnCheckAnswer.TabIndex = 0;
            this.btnCheckAnswer.Text = "Kontrol Et";
            this.btnCheckAnswer.UseVisualStyleBackColor = false;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            this.btnCheckAnswer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCheckAnswer_MouseDown);
            this.btnCheckAnswer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCheckAnswer_MouseUp);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.lblQuestion.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblQuestion.Location = new System.Drawing.Point(170, 87);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(98, 35);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "label1";
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(475, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(928, 824);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.richTextBox1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.richTextBox1.Location = new System.Drawing.Point(213, 209);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(338, 37);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // skorlabel1
            // 
            this.skorlabel1.AutoSize = true;
            this.skorlabel1.BackColor = System.Drawing.Color.Sienna;
            this.skorlabel1.Font = new System.Drawing.Font("Book Antiqua", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skorlabel1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.skorlabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.skorlabel1.Location = new System.Drawing.Point(703, 26);
            this.skorlabel1.Name = "skorlabel1";
            this.skorlabel1.Size = new System.Drawing.Size(91, 40);
            this.skorlabel1.TabIndex = 5;
            this.skorlabel1.Text = "skor:";
            this.skorlabel1.Click += new System.EventHandler(this.skorlabel1_Click);
            // 
            // A
            // 
            this.A.BackColor = System.Drawing.Color.LightBlue;
            this.A.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.A.Location = new System.Drawing.Point(103, 294);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(50, 50);
            this.A.TabIndex = 7;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = false;
            this.A.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.A.Click += new System.EventHandler(this.btn_Click);
            this.A.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.A.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightBlue;
            this.button3.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(157, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "B";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button3.Click += new System.EventHandler(this.btn_Click);
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightBlue;
            this.button4.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(209, 294);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 50);
            this.button4.TabIndex = 9;
            this.button4.Text = "C";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button4.Click += new System.EventHandler(this.btn_Click);
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightBlue;
            this.button5.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.Location = new System.Drawing.Point(320, 294);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 10;
            this.button5.Text = "D";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button5.Click += new System.EventHandler(this.btn_Click);
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightBlue;
            this.button6.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button6.Location = new System.Drawing.Point(376, 294);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 11;
            this.button6.Text = "E";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button6.Click += new System.EventHandler(this.btn_Click);
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button6.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightBlue;
            this.button7.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button7.Location = new System.Drawing.Point(374, 350);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 16;
            this.button7.Text = "K";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button7.Click += new System.EventHandler(this.btn_Click);
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightBlue;
            this.button8.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button8.Location = new System.Drawing.Point(321, 350);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 15;
            this.button8.Text = "J";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button8.Click += new System.EventHandler(this.btn_Click);
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button8.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightBlue;
            this.button9.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button9.Location = new System.Drawing.Point(267, 350);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 50);
            this.button9.TabIndex = 14;
            this.button9.Text = "İ";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button9.Click += new System.EventHandler(this.btn_Click);
            this.button9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button9.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.LightBlue;
            this.button10.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button10.Location = new System.Drawing.Point(209, 350);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 50);
            this.button10.TabIndex = 13;
            this.button10.Text = "I";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button10.Click += new System.EventHandler(this.btn_Click);
            this.button10.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button10.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.LightBlue;
            this.button11.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button11.Location = new System.Drawing.Point(155, 350);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(50, 50);
            this.button11.TabIndex = 12;
            this.button11.Text = "H";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button11.Click += new System.EventHandler(this.btn_Click);
            this.button11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button11.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.LightBlue;
            this.button12.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button12.Location = new System.Drawing.Point(376, 408);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(50, 50);
            this.button12.TabIndex = 26;
            this.button12.Text = "S";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button12.Click += new System.EventHandler(this.btn_Click);
            this.button12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button12.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.LightBlue;
            this.button13.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button13.Location = new System.Drawing.Point(323, 408);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(50, 50);
            this.button13.TabIndex = 25;
            this.button13.Text = "R";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button13.Click += new System.EventHandler(this.btn_Click);
            this.button13.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button13.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.LightBlue;
            this.button14.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button14.Location = new System.Drawing.Point(269, 408);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(50, 50);
            this.button14.TabIndex = 24;
            this.button14.Text = "P";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button14.Click += new System.EventHandler(this.btn_Click);
            this.button14.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button14.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.LightBlue;
            this.button15.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button15.Location = new System.Drawing.Point(211, 408);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(50, 50);
            this.button15.TabIndex = 23;
            this.button15.Text = "Ö";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button15.Click += new System.EventHandler(this.btn_Click);
            this.button15.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button15.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.LightBlue;
            this.button16.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button16.Location = new System.Drawing.Point(157, 408);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(50, 50);
            this.button16.TabIndex = 22;
            this.button16.Text = "O";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button16.Click += new System.EventHandler(this.btn_Click);
            this.button16.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button16.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.LightBlue;
            this.button17.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button17.Location = new System.Drawing.Point(486, 350);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(50, 50);
            this.button17.TabIndex = 21;
            this.button17.Text = "M";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button17.Click += new System.EventHandler(this.btn_Click);
            this.button17.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button17.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.LightBlue;
            this.button18.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button18.Location = new System.Drawing.Point(486, 406);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(50, 50);
            this.button18.TabIndex = 20;
            this.button18.Text = "T";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button18.Click += new System.EventHandler(this.btn_Click);
            this.button18.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button18.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.LightBlue;
            this.button19.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button19.Location = new System.Drawing.Point(432, 350);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(50, 50);
            this.button19.TabIndex = 19;
            this.button19.Text = "L";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button19.Click += new System.EventHandler(this.btn_Click);
            this.button19.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button19.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.LightBlue;
            this.button20.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button20.Location = new System.Drawing.Point(488, 294);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(50, 50);
            this.button20.TabIndex = 18;
            this.button20.Text = "G";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button20.Click += new System.EventHandler(this.btn_Click);
            this.button20.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button20.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.LightBlue;
            this.button21.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button21.Location = new System.Drawing.Point(432, 294);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(50, 50);
            this.button21.TabIndex = 17;
            this.button21.Text = "F";
            this.button21.UseVisualStyleBackColor = false;
            this.button21.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button21.Click += new System.EventHandler(this.btn_Click);
            this.button21.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button21.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.LightBlue;
            this.button27.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button27.Location = new System.Drawing.Point(434, 406);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(50, 50);
            this.button27.TabIndex = 31;
            this.button27.Text = "Ş";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button27.Click += new System.EventHandler(this.btn_Click);
            this.button27.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button27.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button28
            // 
            this.button28.BackColor = System.Drawing.Color.LightBlue;
            this.button28.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button28.Location = new System.Drawing.Point(267, 466);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(50, 50);
            this.button28.TabIndex = 30;
            this.button28.Text = "Y";
            this.button28.UseVisualStyleBackColor = false;
            this.button28.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button28.Click += new System.EventHandler(this.btn_Click);
            this.button28.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button28.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.LightBlue;
            this.button29.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button29.Location = new System.Drawing.Point(213, 466);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(50, 50);
            this.button29.TabIndex = 29;
            this.button29.Text = "V";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button29.Click += new System.EventHandler(this.btn_Click);
            this.button29.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button29.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.LightBlue;
            this.button30.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button30.Location = new System.Drawing.Point(155, 466);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(50, 50);
            this.button30.TabIndex = 28;
            this.button30.Text = "Ü";
            this.button30.UseVisualStyleBackColor = false;
            this.button30.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button30.Click += new System.EventHandler(this.btn_Click);
            this.button30.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button30.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.LightBlue;
            this.button31.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button31.Location = new System.Drawing.Point(101, 466);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(50, 50);
            this.button31.TabIndex = 27;
            this.button31.Text = "U";
            this.button31.UseVisualStyleBackColor = false;
            this.button31.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button31.Click += new System.EventHandler(this.btn_Click);
            this.button31.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button31.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.LightBlue;
            this.button23.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button23.Location = new System.Drawing.Point(101, 406);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(50, 50);
            this.button23.TabIndex = 36;
            this.button23.Text = "N";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button23.Click += new System.EventHandler(this.btn_Click);
            this.button23.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button23.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.Color.LightBlue;
            this.button24.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button24.Location = new System.Drawing.Point(103, 352);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(50, 50);
            this.button24.TabIndex = 35;
            this.button24.Text = "Ğ";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button24.Click += new System.EventHandler(this.btn_Click);
            this.button24.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button24.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.LightBlue;
            this.button26.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button26.Location = new System.Drawing.Point(267, 294);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(50, 50);
            this.button26.TabIndex = 33;
            this.button26.Text = "Ç";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button26.Click += new System.EventHandler(this.btn_Click);
            this.button26.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button26.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.LightBlue;
            this.button32.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button32.Location = new System.Drawing.Point(320, 466);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(50, 50);
            this.button32.TabIndex = 32;
            this.button32.Text = "Z";
            this.button32.UseVisualStyleBackColor = false;
            this.button32.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button32.Click += new System.EventHandler(this.btn_Click);
            this.button32.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button32.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(544, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 37;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.BackColorChanged += new System.EventHandler(this.btn_Click);
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseDown);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_Click_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Sienna;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(348, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 38;
            this.label1.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 624);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button32);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button28);
            this.Controls.Add(this.button29);
            this.Controls.Add(this.button30);
            this.Controls.Add(this.button31);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.A);
            this.Controls.Add(this.skorlabel1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnCheckAnswer);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label skorlabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

