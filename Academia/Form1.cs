using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class ACADEMIA : Form
    {
        public ACADEMIA()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ACADEMIA));
            this.lbl_LogOff = new System.Windows.Forms.Label();
            this.lbl_CadastroMod = new System.Windows.Forms.Label();
            this.lbl_Relatorios = new System.Windows.Forms.Label();
            this.lbl_AlterarSenha = new System.Windows.Forms.Label();
            this.lbl_CadastroProf = new System.Windows.Forms.Label();
            this.lbl_CadastroUsuarios = new System.Windows.Forms.Label();
            this.lbl_CadastroTurmas = new System.Windows.Forms.Label();
            this.lbl_CadastroAlunos = new System.Windows.Forms.Label();
            this.pictLogOff = new System.Windows.Forms.PictureBox();
            this.pictCadastroMod = new System.Windows.Forms.PictureBox();
            this.pictCadastroTurmas = new System.Windows.Forms.PictureBox();
            this.pictCadastroProfessores = new System.Windows.Forms.PictureBox();
            this.pictRelatorios = new System.Windows.Forms.PictureBox();
            this.pictAlterarSenha = new System.Windows.Forms.PictureBox();
            this.pictCadastroUsuarios = new System.Windows.Forms.PictureBox();
            this.pictCadastroAlunos = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_FormatoData = new System.Windows.Forms.Label();
            this.lbl_Data = new System.Windows.Forms.Label();
            this.lbl_FormatoHora = new System.Windows.Forms.Label();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pict_Cancel = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCadastroMod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCadastroTurmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCadastroProfessores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRelatorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictAlterarSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCadastroUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCadastroAlunos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_Cancel)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_LogOff
            // 
            this.lbl_LogOff.AutoSize = true;
            this.lbl_LogOff.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_LogOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_LogOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LogOff.Location = new System.Drawing.Point(705, 364);
            this.lbl_LogOff.Name = "lbl_LogOff";
            this.lbl_LogOff.Size = new System.Drawing.Size(55, 17);
            this.lbl_LogOff.TabIndex = 33;
            this.lbl_LogOff.Text = "Log Off";
            // 
            // lbl_CadastroMod
            // 
            this.lbl_CadastroMod.AutoSize = true;
            this.lbl_CadastroMod.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_CadastroMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_CadastroMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CadastroMod.Location = new System.Drawing.Point(43, 364);
            this.lbl_CadastroMod.Name = "lbl_CadastroMod";
            this.lbl_CadastroMod.Size = new System.Drawing.Size(169, 17);
            this.lbl_CadastroMod.TabIndex = 32;
            this.lbl_CadastroMod.Text = "Cadastro de Modalidades";
            // 
            // lbl_Relatorios
            // 
            this.lbl_Relatorios.AutoSize = true;
            this.lbl_Relatorios.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Relatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Relatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Relatorios.Location = new System.Drawing.Point(301, 364);
            this.lbl_Relatorios.Name = "lbl_Relatorios";
            this.lbl_Relatorios.Size = new System.Drawing.Size(72, 17);
            this.lbl_Relatorios.TabIndex = 31;
            this.lbl_Relatorios.Text = "Relatórios";
            // 
            // lbl_AlterarSenha
            // 
            this.lbl_AlterarSenha.AutoSize = true;
            this.lbl_AlterarSenha.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_AlterarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_AlterarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AlterarSenha.Location = new System.Drawing.Point(495, 364);
            this.lbl_AlterarSenha.Name = "lbl_AlterarSenha";
            this.lbl_AlterarSenha.Size = new System.Drawing.Size(95, 17);
            this.lbl_AlterarSenha.TabIndex = 30;
            this.lbl_AlterarSenha.Text = "Alterar Senha";
            // 
            // lbl_CadastroProf
            // 
            this.lbl_CadastroProf.AutoSize = true;
            this.lbl_CadastroProf.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_CadastroProf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_CadastroProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CadastroProf.Location = new System.Drawing.Point(655, 213);
            this.lbl_CadastroProf.Name = "lbl_CadastroProf";
            this.lbl_CadastroProf.Size = new System.Drawing.Size(165, 17);
            this.lbl_CadastroProf.TabIndex = 29;
            this.lbl_CadastroProf.Text = "Cadastro de Professores";
            // 
            // lbl_CadastroUsuarios
            // 
            this.lbl_CadastroUsuarios.AutoSize = true;
            this.lbl_CadastroUsuarios.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_CadastroUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_CadastroUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CadastroUsuarios.Location = new System.Drawing.Point(461, 213);
            this.lbl_CadastroUsuarios.Name = "lbl_CadastroUsuarios";
            this.lbl_CadastroUsuarios.Size = new System.Drawing.Size(145, 17);
            this.lbl_CadastroUsuarios.TabIndex = 28;
            this.lbl_CadastroUsuarios.Text = "Cadastro de Usuários";
            // 
            // lbl_CadastroTurmas
            // 
            this.lbl_CadastroTurmas.AutoSize = true;
            this.lbl_CadastroTurmas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_CadastroTurmas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_CadastroTurmas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CadastroTurmas.Location = new System.Drawing.Point(267, 213);
            this.lbl_CadastroTurmas.Name = "lbl_CadastroTurmas";
            this.lbl_CadastroTurmas.Size = new System.Drawing.Size(141, 17);
            this.lbl_CadastroTurmas.TabIndex = 27;
            this.lbl_CadastroTurmas.Text = " Cadastro de Turmas";
            // 
            // lbl_CadastroAlunos
            // 
            this.lbl_CadastroAlunos.AutoSize = true;
            this.lbl_CadastroAlunos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_CadastroAlunos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_CadastroAlunos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CadastroAlunos.Location = new System.Drawing.Point(58, 213);
            this.lbl_CadastroAlunos.Name = "lbl_CadastroAlunos";
            this.lbl_CadastroAlunos.Size = new System.Drawing.Size(132, 17);
            this.lbl_CadastroAlunos.TabIndex = 26;
            this.lbl_CadastroAlunos.Text = "Cadastro de Alunos";
            // 
            // pictLogOff
            // 
            this.pictLogOff.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictLogOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictLogOff.Image = ((System.Drawing.Image)(resources.GetObject("pictLogOff.Image")));
            this.pictLogOff.Location = new System.Drawing.Point(646, 261);
            this.pictLogOff.Name = "pictLogOff";
            this.pictLogOff.Size = new System.Drawing.Size(181, 132);
            this.pictLogOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictLogOff.TabIndex = 25;
            this.pictLogOff.TabStop = false;
            // 
            // pictCadastroMod
            // 
            this.pictCadastroMod.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictCadastroMod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictCadastroMod.Image = ((System.Drawing.Image)(resources.GetObject("pictCadastroMod.Image")));
            this.pictCadastroMod.Location = new System.Drawing.Point(34, 261);
            this.pictCadastroMod.Name = "pictCadastroMod";
            this.pictCadastroMod.Size = new System.Drawing.Size(188, 132);
            this.pictCadastroMod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictCadastroMod.TabIndex = 24;
            this.pictCadastroMod.TabStop = false;
            // 
            // pictCadastroTurmas
            // 
            this.pictCadastroTurmas.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictCadastroTurmas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictCadastroTurmas.Image = ((System.Drawing.Image)(resources.GetObject("pictCadastroTurmas.Image")));
            this.pictCadastroTurmas.Location = new System.Drawing.Point(244, 107);
            this.pictCadastroTurmas.Name = "pictCadastroTurmas";
            this.pictCadastroTurmas.Size = new System.Drawing.Size(182, 132);
            this.pictCadastroTurmas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictCadastroTurmas.TabIndex = 23;
            this.pictCadastroTurmas.TabStop = false;
            // 
            // pictCadastroProfessores
            // 
            this.pictCadastroProfessores.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictCadastroProfessores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictCadastroProfessores.Image = ((System.Drawing.Image)(resources.GetObject("pictCadastroProfessores.Image")));
            this.pictCadastroProfessores.Location = new System.Drawing.Point(646, 107);
            this.pictCadastroProfessores.Name = "pictCadastroProfessores";
            this.pictCadastroProfessores.Size = new System.Drawing.Size(181, 132);
            this.pictCadastroProfessores.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictCadastroProfessores.TabIndex = 22;
            this.pictCadastroProfessores.TabStop = false;
            // 
            // pictRelatorios
            // 
            this.pictRelatorios.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictRelatorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictRelatorios.Image = ((System.Drawing.Image)(resources.GetObject("pictRelatorios.Image")));
            this.pictRelatorios.Location = new System.Drawing.Point(244, 261);
            this.pictRelatorios.Name = "pictRelatorios";
            this.pictRelatorios.Size = new System.Drawing.Size(182, 132);
            this.pictRelatorios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictRelatorios.TabIndex = 21;
            this.pictRelatorios.TabStop = false;
            // 
            // pictAlterarSenha
            // 
            this.pictAlterarSenha.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictAlterarSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictAlterarSenha.Image = ((System.Drawing.Image)(resources.GetObject("pictAlterarSenha.Image")));
            this.pictAlterarSenha.Location = new System.Drawing.Point(447, 261);
            this.pictAlterarSenha.Name = "pictAlterarSenha";
            this.pictAlterarSenha.Size = new System.Drawing.Size(182, 132);
            this.pictAlterarSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictAlterarSenha.TabIndex = 20;
            this.pictAlterarSenha.TabStop = false;
            // 
            // pictCadastroUsuarios
            // 
            this.pictCadastroUsuarios.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictCadastroUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictCadastroUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("pictCadastroUsuarios.Image")));
            this.pictCadastroUsuarios.Location = new System.Drawing.Point(447, 107);
            this.pictCadastroUsuarios.Name = "pictCadastroUsuarios";
            this.pictCadastroUsuarios.Size = new System.Drawing.Size(182, 132);
            this.pictCadastroUsuarios.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictCadastroUsuarios.TabIndex = 19;
            this.pictCadastroUsuarios.TabStop = false;
            // 
            // pictCadastroAlunos
            // 
            this.pictCadastroAlunos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictCadastroAlunos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictCadastroAlunos.Image = ((System.Drawing.Image)(resources.GetObject("pictCadastroAlunos.Image")));
            this.pictCadastroAlunos.Location = new System.Drawing.Point(33, 107);
            this.pictCadastroAlunos.Name = "pictCadastroAlunos";
            this.pictCadastroAlunos.Size = new System.Drawing.Size(189, 132);
            this.pictCadastroAlunos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictCadastroAlunos.TabIndex = 18;
            this.pictCadastroAlunos.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Cyan;
            this.panel2.Controls.Add(this.lbl_FormatoData);
            this.panel2.Controls.Add(this.lbl_Data);
            this.panel2.Controls.Add(this.lbl_FormatoHora);
            this.panel2.Controls.Add(this.lbl_Hora);
            this.panel2.Controls.Add(this.lbl_Usuario);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 459);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(881, 41);
            this.panel2.TabIndex = 34;
            // 
            // lbl_FormatoData
            // 
            this.lbl_FormatoData.AutoSize = true;
            this.lbl_FormatoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormatoData.Location = new System.Drawing.Point(745, 11);
            this.lbl_FormatoData.Name = "lbl_FormatoData";
            this.lbl_FormatoData.Size = new System.Drawing.Size(80, 17);
            this.lbl_FormatoData.TabIndex = 12;
            this.lbl_FormatoData.Text = "00/00/0000";
            // 
            // lbl_Data
            // 
            this.lbl_Data.AutoSize = true;
            this.lbl_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Data.Location = new System.Drawing.Point(697, 11);
            this.lbl_Data.Name = "lbl_Data";
            this.lbl_Data.Size = new System.Drawing.Size(42, 17);
            this.lbl_Data.TabIndex = 11;
            this.lbl_Data.Text = "Data:";
            // 
            // lbl_FormatoHora
            // 
            this.lbl_FormatoHora.AutoSize = true;
            this.lbl_FormatoHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FormatoHora.Location = new System.Drawing.Point(588, 11);
            this.lbl_FormatoHora.Name = "lbl_FormatoHora";
            this.lbl_FormatoHora.Size = new System.Drawing.Size(64, 17);
            this.lbl_FormatoHora.TabIndex = 10;
            this.lbl_FormatoHora.Text = "00:00:00";
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hora.Location = new System.Drawing.Point(541, 11);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(43, 17);
            this.lbl_Hora.TabIndex = 2;
            this.lbl_Hora.Text = "Hora:";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Usuario.Location = new System.Drawing.Point(12, 11);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(57, 17);
            this.lbl_Usuario.TabIndex = 1;
            this.lbl_Usuario.Text = "Usuário";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Chartreuse;
            this.panel1.Controls.Add(this.pict_Cancel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 47);
            this.panel1.TabIndex = 35;
            // 
            // pict_Cancel
            // 
            this.pict_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pict_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("pict_Cancel.Image")));
            this.pict_Cancel.Location = new System.Drawing.Point(887, 12);
            this.pict_Cancel.Name = "pict_Cancel";
            this.pict_Cancel.Size = new System.Drawing.Size(26, 23);
            this.pict_Cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pict_Cancel.TabIndex = 18;
            this.pict_Cancel.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(246, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciamento de Academia";
            // 
            // ACADEMIA
            // 
            this.ClientSize = new System.Drawing.Size(881, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_LogOff);
            this.Controls.Add(this.lbl_CadastroMod);
            this.Controls.Add(this.lbl_Relatorios);
            this.Controls.Add(this.lbl_AlterarSenha);
            this.Controls.Add(this.lbl_CadastroProf);
            this.Controls.Add(this.lbl_CadastroUsuarios);
            this.Controls.Add(this.lbl_CadastroTurmas);
            this.Controls.Add(this.lbl_CadastroAlunos);
            this.Controls.Add(this.pictLogOff);
            this.Controls.Add(this.pictCadastroMod);
            this.Controls.Add(this.pictCadastroTurmas);
            this.Controls.Add(this.pictCadastroProfessores);
            this.Controls.Add(this.pictRelatorios);
            this.Controls.Add(this.pictAlterarSenha);
            this.Controls.Add(this.pictCadastroUsuarios);
            this.Controls.Add(this.pictCadastroAlunos);
            this.Name = "ACADEMIA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ACADEMIA";
            this.Load += new System.EventHandler(this.ACADEMIA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictLogOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCadastroMod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCadastroTurmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCadastroProfessores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRelatorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictAlterarSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCadastroUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCadastroAlunos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_Cancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ACADEMIA_Load(object sender, EventArgs e)
        {
                
        }
    }
}
