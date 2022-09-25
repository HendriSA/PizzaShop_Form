namespace HendricksonSamuel_PizzaForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblOptions = new System.Windows.Forms.Label();
            this.chkbxOnions = new System.Windows.Forms.CheckBox();
            this.chkbxPeppers = new System.Windows.Forms.CheckBox();
            this.chkbxPep = new System.Windows.Forms.CheckBox();
            this.chkbxSausage = new System.Windows.Forms.CheckBox();
            this.rbtnPickUp = new System.Windows.Forms.RadioButton();
            this.rbtnDelivery = new System.Windows.Forms.RadioButton();
            this.rbtnDineIn = new System.Windows.Forms.RadioButton();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.lstBxToppingsHolder = new System.Windows.Forms.ListBox();
            this.lstBxToppingsVisible = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(82, 29);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(174, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Pizza Order Form";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(15, 74);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(138, 20);
            this.lblToppings.TabIndex = 1;
            this.lblToppings.Text = "Select Toppings";
            // 
            // lblOptions
            // 
            this.lblOptions.AutoSize = true;
            this.lblOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptions.Location = new System.Drawing.Point(197, 74);
            this.lblOptions.Name = "lblOptions";
            this.lblOptions.Size = new System.Drawing.Size(127, 20);
            this.lblOptions.TabIndex = 2;
            this.lblOptions.Text = "Dining Options";
            // 
            // chkbxOnions
            // 
            this.chkbxOnions.AutoSize = true;
            this.chkbxOnions.Location = new System.Drawing.Point(19, 111);
            this.chkbxOnions.Name = "chkbxOnions";
            this.chkbxOnions.Size = new System.Drawing.Size(59, 17);
            this.chkbxOnions.TabIndex = 3;
            this.chkbxOnions.Text = "Onions";
            this.chkbxOnions.UseVisualStyleBackColor = true;
            this.chkbxOnions.CheckedChanged += new System.EventHandler(this.chkbxOnions_CheckedChanged);
            // 
            // chkbxPeppers
            // 
            this.chkbxPeppers.AutoSize = true;
            this.chkbxPeppers.Location = new System.Drawing.Point(19, 134);
            this.chkbxPeppers.Name = "chkbxPeppers";
            this.chkbxPeppers.Size = new System.Drawing.Size(97, 17);
            this.chkbxPeppers.TabIndex = 4;
            this.chkbxPeppers.Text = "Green Peppers";
            this.chkbxPeppers.UseVisualStyleBackColor = true;
            this.chkbxPeppers.CheckedChanged += new System.EventHandler(this.chkbxPeppers_CheckedChanged);
            // 
            // chkbxPep
            // 
            this.chkbxPep.AutoSize = true;
            this.chkbxPep.Location = new System.Drawing.Point(19, 157);
            this.chkbxPep.Name = "chkbxPep";
            this.chkbxPep.Size = new System.Drawing.Size(74, 17);
            this.chkbxPep.TabIndex = 5;
            this.chkbxPep.Text = "Pepperoni";
            this.chkbxPep.UseVisualStyleBackColor = true;
            this.chkbxPep.CheckedChanged += new System.EventHandler(this.chkbxPep_CheckedChanged);
            // 
            // chkbxSausage
            // 
            this.chkbxSausage.AutoSize = true;
            this.chkbxSausage.Location = new System.Drawing.Point(19, 180);
            this.chkbxSausage.Name = "chkbxSausage";
            this.chkbxSausage.Size = new System.Drawing.Size(68, 17);
            this.chkbxSausage.TabIndex = 6;
            this.chkbxSausage.Text = "Sausage";
            this.chkbxSausage.UseVisualStyleBackColor = true;
            this.chkbxSausage.CheckedChanged += new System.EventHandler(this.chkbxSausage_CheckedChanged);
            // 
            // rbtnPickUp
            // 
            this.rbtnPickUp.AutoSize = true;
            this.rbtnPickUp.Location = new System.Drawing.Point(201, 111);
            this.rbtnPickUp.Name = "rbtnPickUp";
            this.rbtnPickUp.Size = new System.Drawing.Size(63, 17);
            this.rbtnPickUp.TabIndex = 7;
            this.rbtnPickUp.TabStop = true;
            this.rbtnPickUp.Text = "Pick Up";
            this.rbtnPickUp.UseVisualStyleBackColor = true;
            this.rbtnPickUp.CheckedChanged += new System.EventHandler(this.rbtnPickUp_CheckedChanged);
            // 
            // rbtnDelivery
            // 
            this.rbtnDelivery.AutoSize = true;
            this.rbtnDelivery.Location = new System.Drawing.Point(201, 134);
            this.rbtnDelivery.Name = "rbtnDelivery";
            this.rbtnDelivery.Size = new System.Drawing.Size(63, 17);
            this.rbtnDelivery.TabIndex = 8;
            this.rbtnDelivery.TabStop = true;
            this.rbtnDelivery.Text = "Delivery";
            this.rbtnDelivery.UseVisualStyleBackColor = true;
            this.rbtnDelivery.CheckedChanged += new System.EventHandler(this.rbtnDelivery_CheckedChanged);
            // 
            // rbtnDineIn
            // 
            this.rbtnDineIn.AutoSize = true;
            this.rbtnDineIn.Location = new System.Drawing.Point(201, 157);
            this.rbtnDineIn.Name = "rbtnDineIn";
            this.rbtnDineIn.Size = new System.Drawing.Size(59, 17);
            this.rbtnDineIn.TabIndex = 9;
            this.rbtnDineIn.TabStop = true;
            this.rbtnDineIn.Text = "Dine In";
            this.rbtnDineIn.UseVisualStyleBackColor = true;
            this.rbtnDineIn.CheckedChanged += new System.EventHandler(this.rbtnDineIn_CheckedChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(198, 208);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 10;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(18, 203);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 11;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(111, 203);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 12;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.button2_Click);
            // 
            // lstBxToppingsHolder
            // 
            this.lstBxToppingsHolder.FormattingEnabled = true;
            this.lstBxToppingsHolder.Location = new System.Drawing.Point(19, 233);
            this.lstBxToppingsHolder.Name = "lstBxToppingsHolder";
            this.lstBxToppingsHolder.Size = new System.Drawing.Size(308, 173);
            this.lstBxToppingsHolder.TabIndex = 13;
            this.lstBxToppingsHolder.Visible = false;
            // 
            // lstBxToppingsVisible
            // 
            this.lstBxToppingsVisible.FormattingEnabled = true;
            this.lstBxToppingsVisible.HorizontalScrollbar = true;
            this.lstBxToppingsVisible.Location = new System.Drawing.Point(19, 233);
            this.lstBxToppingsVisible.Name = "lstBxToppingsVisible";
            this.lstBxToppingsVisible.Size = new System.Drawing.Size(308, 173);
            this.lstBxToppingsVisible.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 417);
            this.Controls.Add(this.lstBxToppingsVisible);
            this.Controls.Add(this.lstBxToppingsHolder);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.rbtnDineIn);
            this.Controls.Add(this.rbtnDelivery);
            this.Controls.Add(this.rbtnPickUp);
            this.Controls.Add(this.chkbxSausage);
            this.Controls.Add(this.chkbxPep);
            this.Controls.Add(this.chkbxPeppers);
            this.Controls.Add(this.chkbxOnions);
            this.Controls.Add(this.lblOptions);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Pizza Order Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblOptions;
        private System.Windows.Forms.CheckBox chkbxOnions;
        private System.Windows.Forms.CheckBox chkbxPeppers;
        private System.Windows.Forms.CheckBox chkbxPep;
        private System.Windows.Forms.CheckBox chkbxSausage;
        private System.Windows.Forms.RadioButton rbtnPickUp;
        private System.Windows.Forms.RadioButton rbtnDelivery;
        private System.Windows.Forms.RadioButton rbtnDineIn;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ListBox lstBxToppingsHolder;
        private System.Windows.Forms.ListBox lstBxToppingsVisible;
    }
}

