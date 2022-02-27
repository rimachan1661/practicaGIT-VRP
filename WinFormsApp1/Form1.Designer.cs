
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    class Alumno
    {
        private string nombre;
        private int nota;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Nota
        {
            get { return nota; }
            set
            {
                if (value >= 0 && value <= 10)
                    nota = value;
            }
        }
        public Boolean Aprobado
        {
            get
            {
                if (nota >= 5)
                    return true;
                else
                    return false;
            }
        }
    }

    class Alumnos
    {
        private ArrayList listaAlumnos = new ArrayList();

        // Agrega un nuevo alumno a la lista
        //        
        public void Agregar(Alumno alu)
        {
            listaAlumnos.Add(alu);
        }

        // Devuelve el alumno que está en la posición num
        //
        public Alumno Obtener(int num)
        {
            if (num >= 0 && num <= listaAlumnos.Count)
            {
                return ((Alumno)listaAlumnos[num]);
            }
            return null;
        }

        // Devuelve la nota media de los alumnos
        //
        public float Media
        {
            get
            {
                if (listaAlumnos.Count == 0)
                    return 0;
                else
                {
                    float media = 0;
                    for (int i = 0; i < listaAlumnos.Count; i++)
                    {
                        media += ((Alumno)listaAlumnos[i]).Nota;
                    }
                    return (media / listaAlumnos.Count);
                }
            }
        }
    }

    partial class Form1
    {
        Alumnos misAlumnos = new Alumnos();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.aluNombre = new System.Windows.Forms.TextBox();
            this.listaAlumnos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.aluNota = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.aluNota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota";
            // 
            // aluNombre
            // 
            this.aluNombre.Location = new System.Drawing.Point(101, 43);
            this.aluNombre.Name = "aluNombre";
            this.aluNombre.Size = new System.Drawing.Size(125, 27);
            this.aluNombre.TabIndex = 2;
            // 
            // listaAlumnos
            // 
            this.listaAlumnos.Location = new System.Drawing.Point(130, 98);
            this.listaAlumnos.MaximumSize = new System.Drawing.Size(300, 100);
            this.listaAlumnos.MinimumSize = new System.Drawing.Size(500, 300);
            this.listaAlumnos.Name = "listaAlumnos";
            this.listaAlumnos.ReadOnly = true;
            this.listaAlumnos.Size = new System.Drawing.Size(500, 300);
            this.listaAlumnos.TabIndex = 4;
            this.listaAlumnos.TextChanged += new System.EventHandler(this.listaAlumnos_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(586, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aluNota
            // 
            this.aluNota.Location = new System.Drawing.Point(389, 46);
            this.aluNota.Name = "aluNota";
            this.aluNota.Size = new System.Drawing.Size(150, 27);
            this.aluNota.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aluNota);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listaAlumnos);
            this.Controls.Add(this.aluNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aluNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aluNombre;
        private System.Windows.Forms.TextBox listaAlumnos;
        private System.Windows.Forms.Button button1;

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno miAlumno = new Alumno();
             String miAlumnoStr, miAlumnoNotaTexto;
             miAlumno.Nombre = aluNombre.Text;
             miAlumno.Nota = Convert.ToInt32(aluNota.Text);
            if (miAlumno.Nota<5) {
            miAlumnoNotaTexto = "Suspenso";
            }
            else if (miAlumno.Nota<7) {
            miAlumnoNotaTexto = "Aprobado";
            }
            else if (miAlumno.Nota<9) {
            miAlumnoNotaTexto = "Notable";
            }
            else
            miAlumnoNotaTexto = "Sobresaliente";

            StringBuilder sb = new StringBuilder();
            miAlumnoStr = aluNombre.Text + " " + aluNota.Text + " " + miAlumnoNotaTexto + System.Environment.NewLine;


            //listaAlumnos.AppendText(miAlumnoStr);
            listaAlumnos.Multiline = true;
            listaAlumnos.Text = listaAlumnos.Text + miAlumnoStr;
             misAlumnos.Agregar(miAlumno);
        }

        private NumericUpDown aluNota;
    }
}

