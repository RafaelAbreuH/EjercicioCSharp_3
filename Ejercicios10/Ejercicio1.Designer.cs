namespace EjercicioCSharp_3.Ejercicios10
{
    partial class Ejercicio1
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CodigoProductonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.NombreProductotextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.FechaCaducidadProdcutodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.CantidadProductonumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BuscarProductobutton = new System.Windows.Forms.Button();
            this.GuardarProductobutton = new System.Windows.Forms.Button();
            this.NuevoProductobutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CodigoProductonumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadProductonumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Codigo del Producto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Nombre del producto:";
            // 
            // CodigoProductonumericUpDown
            // 
            this.CodigoProductonumericUpDown.Location = new System.Drawing.Point(115, 22);
            this.CodigoProductonumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CodigoProductonumericUpDown.Name = "CodigoProductonumericUpDown";
            this.CodigoProductonumericUpDown.Size = new System.Drawing.Size(56, 20);
            this.CodigoProductonumericUpDown.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Precio del Producto:";
            // 
            // NombreProductotextBox
            // 
            this.NombreProductotextBox.Location = new System.Drawing.Point(115, 58);
            this.NombreProductotextBox.Name = "NombreProductotextBox";
            this.NombreProductotextBox.Size = new System.Drawing.Size(149, 20);
            this.NombreProductotextBox.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Fecha de Caducidad:";
            // 
            // FechaCaducidadProdcutodateTimePicker
            // 
            this.FechaCaducidadProdcutodateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaCaducidadProdcutodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaCaducidadProdcutodateTimePicker.Location = new System.Drawing.Point(115, 122);
            this.FechaCaducidadProdcutodateTimePicker.Name = "FechaCaducidadProdcutodateTimePicker";
            this.FechaCaducidadProdcutodateTimePicker.Size = new System.Drawing.Size(149, 20);
            this.FechaCaducidadProdcutodateTimePicker.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Cantidad";
            // 
            // CantidadProductonumericUpDown
            // 
            this.CantidadProductonumericUpDown.Location = new System.Drawing.Point(115, 154);
            this.CantidadProductonumericUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CantidadProductonumericUpDown.Name = "CantidadProductonumericUpDown";
            this.CantidadProductonumericUpDown.Size = new System.Drawing.Size(149, 20);
            this.CantidadProductonumericUpDown.TabIndex = 16;
            // 
            // BuscarProductobutton
            // 
            this.BuscarProductobutton.Location = new System.Drawing.Point(177, 19);
            this.BuscarProductobutton.Name = "BuscarProductobutton";
            this.BuscarProductobutton.Size = new System.Drawing.Size(75, 23);
            this.BuscarProductobutton.TabIndex = 17;
            this.BuscarProductobutton.Text = "Buscar";
            this.BuscarProductobutton.UseVisualStyleBackColor = true;
            // 
            // GuardarProductobutton
            // 
            this.GuardarProductobutton.Location = new System.Drawing.Point(12, 187);
            this.GuardarProductobutton.Name = "GuardarProductobutton";
            this.GuardarProductobutton.Size = new System.Drawing.Size(75, 23);
            this.GuardarProductobutton.TabIndex = 18;
            this.GuardarProductobutton.Text = "Guardar";
            this.GuardarProductobutton.UseVisualStyleBackColor = true;
            // 
            // NuevoProductobutton
            // 
            this.NuevoProductobutton.Location = new System.Drawing.Point(106, 187);
            this.NuevoProductobutton.Name = "NuevoProductobutton";
            this.NuevoProductobutton.Size = new System.Drawing.Size(75, 23);
            this.NuevoProductobutton.TabIndex = 19;
            this.NuevoProductobutton.Text = "Nuevo";
            this.NuevoProductobutton.UseVisualStyleBackColor = true;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(199, 187);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 23);
            this.Eliminarbutton.TabIndex = 20;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            // 
            // Ejercicio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 222);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.NuevoProductobutton);
            this.Controls.Add(this.GuardarProductobutton);
            this.Controls.Add(this.BuscarProductobutton);
            this.Controls.Add(this.CantidadProductonumericUpDown);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.FechaCaducidadProdcutodateTimePicker);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.NombreProductotextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.CodigoProductonumericUpDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "Ejercicio1";
            this.Text = "Ejercicio1";
            ((System.ComponentModel.ISupportInitialize)(this.CodigoProductonumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CantidadProductonumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown CodigoProductonumericUpDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NombreProductotextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker FechaCaducidadProdcutodateTimePicker;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown CantidadProductonumericUpDown;
        private System.Windows.Forms.Button BuscarProductobutton;
        private System.Windows.Forms.Button GuardarProductobutton;
        private System.Windows.Forms.Button NuevoProductobutton;
        private System.Windows.Forms.Button Eliminarbutton;
    }
}