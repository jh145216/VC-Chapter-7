namespace Delgados_Taocs
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
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblMainTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnterNameHere = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radCheeseQuesadilla = new System.Windows.Forms.RadioButton();
            this.radPop = new System.Windows.Forms.RadioButton();
            this.radFajita = new System.Windows.Forms.RadioButton();
            this.radReFriedBeans = new System.Windows.Forms.RadioButton();
            this.radBurritos = new System.Windows.Forms.RadioButton();
            this.radTacos = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTacosNumber = new System.Windows.Forms.TextBox();
            this.txtBurritosNumber = new System.Windows.Forms.TextBox();
            this.txtReFriedBeansNumber = new System.Windows.Forms.TextBox();
            this.txtFajitasNumber = new System.Windows.Forms.TextBox();
            this.txtPopsNumber = new System.Windows.Forms.TextBox();
            this.txtCheeseQuesadillasNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(334, 77);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(148, 57);
            this.btnOrder.TabIndex = 60;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblMainTotal
            // 
            this.lblMainTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMainTotal.Location = new System.Drawing.Point(334, 291);
            this.lblMainTotal.Name = "lblMainTotal";
            this.lblMainTotal.Size = new System.Drawing.Size(111, 46);
            this.lblMainTotal.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(349, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Main Total";
            // 
            // txtEnterNameHere
            // 
            this.txtEnterNameHere.Location = new System.Drawing.Point(334, 190);
            this.txtEnterNameHere.Name = "txtEnterNameHere";
            this.txtEnterNameHere.Size = new System.Drawing.Size(148, 20);
            this.txtEnterNameHere.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Enter your name here";
            // 
            // radCheeseQuesadilla
            // 
            this.radCheeseQuesadilla.AutoSize = true;
            this.radCheeseQuesadilla.Location = new System.Drawing.Point(26, 281);
            this.radCheeseQuesadilla.Name = "radCheeseQuesadilla";
            this.radCheeseQuesadilla.Size = new System.Drawing.Size(143, 17);
            this.radCheeseQuesadilla.TabIndex = 50;
            this.radCheeseQuesadilla.Text = "Cheese Quesadilla $1.75";
            this.radCheeseQuesadilla.UseVisualStyleBackColor = true;
            // 
            // radPop
            // 
            this.radPop.AutoSize = true;
            this.radPop.Location = new System.Drawing.Point(26, 249);
            this.radPop.Name = "radPop";
            this.radPop.Size = new System.Drawing.Size(74, 17);
            this.radPop.TabIndex = 49;
            this.radPop.Text = "Pop $1.00";
            this.radPop.UseVisualStyleBackColor = true;
            // 
            // radFajita
            // 
            this.radFajita.AutoSize = true;
            this.radFajita.Location = new System.Drawing.Point(26, 213);
            this.radFajita.Name = "radFajita";
            this.radFajita.Size = new System.Drawing.Size(80, 17);
            this.radFajita.TabIndex = 48;
            this.radFajita.Text = "Fajita $1.50";
            this.radFajita.UseVisualStyleBackColor = true;
            // 
            // radReFriedBeans
            // 
            this.radReFriedBeans.AutoSize = true;
            this.radReFriedBeans.Location = new System.Drawing.Point(26, 178);
            this.radReFriedBeans.Name = "radReFriedBeans";
            this.radReFriedBeans.Size = new System.Drawing.Size(125, 17);
            this.radReFriedBeans.TabIndex = 47;
            this.radReFriedBeans.Text = "ReFried Beans $0.50";
            this.radReFriedBeans.UseVisualStyleBackColor = true;
            // 
            // radBurritos
            // 
            this.radBurritos.AutoSize = true;
            this.radBurritos.Location = new System.Drawing.Point(26, 142);
            this.radBurritos.Name = "radBurritos";
            this.radBurritos.Size = new System.Drawing.Size(90, 17);
            this.radBurritos.TabIndex = 46;
            this.radBurritos.Text = "Burritos $1.99";
            this.radBurritos.UseVisualStyleBackColor = true;
            // 
            // radTacos
            // 
            this.radTacos.AutoSize = true;
            this.radTacos.Location = new System.Drawing.Point(26, 104);
            this.radTacos.Name = "radTacos";
            this.radTacos.Size = new System.Drawing.Size(85, 17);
            this.radTacos.TabIndex = 45;
            this.radTacos.Text = "Tacos $0.99";
            this.radTacos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "What would you want to order";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "Welcome to Delgados Tacos";
            // 
            // txtTacosNumber
            // 
            this.txtTacosNumber.Location = new System.Drawing.Point(184, 107);
            this.txtTacosNumber.Name = "txtTacosNumber";
            this.txtTacosNumber.Size = new System.Drawing.Size(71, 20);
            this.txtTacosNumber.TabIndex = 61;
            // 
            // txtBurritosNumber
            // 
            this.txtBurritosNumber.Location = new System.Drawing.Point(184, 142);
            this.txtBurritosNumber.Name = "txtBurritosNumber";
            this.txtBurritosNumber.Size = new System.Drawing.Size(71, 20);
            this.txtBurritosNumber.TabIndex = 62;
            // 
            // txtReFriedBeansNumber
            // 
            this.txtReFriedBeansNumber.Location = new System.Drawing.Point(184, 178);
            this.txtReFriedBeansNumber.Name = "txtReFriedBeansNumber";
            this.txtReFriedBeansNumber.Size = new System.Drawing.Size(71, 20);
            this.txtReFriedBeansNumber.TabIndex = 63;
            // 
            // txtFajitasNumber
            // 
            this.txtFajitasNumber.Location = new System.Drawing.Point(184, 213);
            this.txtFajitasNumber.Name = "txtFajitasNumber";
            this.txtFajitasNumber.Size = new System.Drawing.Size(71, 20);
            this.txtFajitasNumber.TabIndex = 64;
            // 
            // txtPopsNumber
            // 
            this.txtPopsNumber.Location = new System.Drawing.Point(184, 249);
            this.txtPopsNumber.Name = "txtPopsNumber";
            this.txtPopsNumber.Size = new System.Drawing.Size(71, 20);
            this.txtPopsNumber.TabIndex = 65;
            // 
            // txtCheeseQuesadillasNumber
            // 
            this.txtCheeseQuesadillasNumber.Location = new System.Drawing.Point(184, 278);
            this.txtCheeseQuesadillasNumber.Name = "txtCheeseQuesadillasNumber";
            this.txtCheeseQuesadillasNumber.Size = new System.Drawing.Size(71, 20);
            this.txtCheeseQuesadillasNumber.TabIndex = 66;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 358);
            this.Controls.Add(this.txtCheeseQuesadillasNumber);
            this.Controls.Add(this.txtPopsNumber);
            this.Controls.Add(this.txtFajitasNumber);
            this.Controls.Add(this.txtReFriedBeansNumber);
            this.Controls.Add(this.txtBurritosNumber);
            this.Controls.Add(this.txtTacosNumber);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lblMainTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEnterNameHere);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radCheeseQuesadilla);
            this.Controls.Add(this.radPop);
            this.Controls.Add(this.radFajita);
            this.Controls.Add(this.radReFriedBeans);
            this.Controls.Add(this.radBurritos);
            this.Controls.Add(this.radTacos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Delgados Tacos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblMainTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEnterNameHere;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radCheeseQuesadilla;
        private System.Windows.Forms.RadioButton radPop;
        private System.Windows.Forms.RadioButton radFajita;
        private System.Windows.Forms.RadioButton radReFriedBeans;
        private System.Windows.Forms.RadioButton radBurritos;
        private System.Windows.Forms.RadioButton radTacos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTacosNumber;
        private System.Windows.Forms.TextBox txtBurritosNumber;
        private System.Windows.Forms.TextBox txtReFriedBeansNumber;
        private System.Windows.Forms.TextBox txtFajitasNumber;
        private System.Windows.Forms.TextBox txtPopsNumber;
        private System.Windows.Forms.TextBox txtCheeseQuesadillasNumber;
    }
}

