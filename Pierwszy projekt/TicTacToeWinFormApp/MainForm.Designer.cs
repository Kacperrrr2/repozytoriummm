
namespace TicTacToeWinFormApp
{
    partial class MainForm
    {
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
            panelConfigGame = new System.Windows.Forms.Panel();
            labelWhoStartGame = new System.Windows.Forms.Label();
            comboBoxWhoStartGame = new System.Windows.Forms.ComboBox();
            buttonNewGame = new System.Windows.Forms.Button();
            tableLayoutPanelBoard = new System.Windows.Forms.TableLayoutPanel();
            buttonPosition00 = new System.Windows.Forms.Button();
            buttonPosition10 = new System.Windows.Forms.Button();
            buttonPosition20 = new System.Windows.Forms.Button();
            buttonPosition01 = new System.Windows.Forms.Button();
            buttonPosition11 = new System.Windows.Forms.Button();
            buttonPosition21 = new System.Windows.Forms.Button();
            buttonPosition22 = new System.Windows.Forms.Button();
            buttonPosition12 = new System.Windows.Forms.Button();
            buttonPosition02 = new System.Windows.Forms.Button();
            panelConfigGame.SuspendLayout();
            tableLayoutPanelBoard.SuspendLayout();
            SuspendLayout();
            // 
            // panelConfigGame
            // 
            panelConfigGame.Controls.Add(labelWhoStartGame);
            panelConfigGame.Controls.Add(comboBoxWhoStartGame);
            panelConfigGame.Controls.Add(buttonNewGame);
            panelConfigGame.Dock = System.Windows.Forms.DockStyle.Top;
            panelConfigGame.Location = new System.Drawing.Point(0, 0);
            panelConfigGame.Name = "panelConfigGame";
            panelConfigGame.Size = new System.Drawing.Size(335, 75);
            panelConfigGame.TabIndex = 4;
            // 
            // labelWhoStartGame
            // 
            labelWhoStartGame.AutoSize = true;
            labelWhoStartGame.Location = new System.Drawing.Point(12, 9);
            labelWhoStartGame.Name = "labelWhoStartGame";
            labelWhoStartGame.Size = new System.Drawing.Size(92, 15);
            labelWhoStartGame.TabIndex = 3;
            labelWhoStartGame.Text = "Kto zaczyna grę:";
            // 
            // comboBoxWhoStartGame
            // 
            comboBoxWhoStartGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxWhoStartGame.FormattingEnabled = true;
            comboBoxWhoStartGame.Items.AddRange(new object[] { "Kółko", "Krzyżyk" });
            comboBoxWhoStartGame.Location = new System.Drawing.Point(12, 30);
            comboBoxWhoStartGame.Name = "comboBoxWhoStartGame";
            comboBoxWhoStartGame.Size = new System.Drawing.Size(121, 23);
            comboBoxWhoStartGame.TabIndex = 2;
            // 
            // buttonNewGame
            // 
            buttonNewGame.Location = new System.Drawing.Point(161, 29);
            buttonNewGame.Name = "buttonNewGame";
            buttonNewGame.Size = new System.Drawing.Size(123, 23);
            buttonNewGame.TabIndex = 0;
            buttonNewGame.Text = "Nowa gra";
            buttonNewGame.UseVisualStyleBackColor = true;
            buttonNewGame.Click += buttonNewGame_Click;
            // 
            // tableLayoutPanelBoard
            // 
            tableLayoutPanelBoard.BackColor = System.Drawing.Color.FromArgb(128, 255, 255);
            tableLayoutPanelBoard.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            tableLayoutPanelBoard.ColumnCount = 3;
            tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            tableLayoutPanelBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            tableLayoutPanelBoard.Controls.Add(buttonPosition00, 0, 0);
            tableLayoutPanelBoard.Controls.Add(buttonPosition10, 1, 0);
            tableLayoutPanelBoard.Controls.Add(buttonPosition20, 2, 0);
            tableLayoutPanelBoard.Controls.Add(buttonPosition01, 0, 1);
            tableLayoutPanelBoard.Controls.Add(buttonPosition11, 1, 1);
            tableLayoutPanelBoard.Controls.Add(buttonPosition21, 2, 1);
            tableLayoutPanelBoard.Controls.Add(buttonPosition22, 2, 2);
            tableLayoutPanelBoard.Controls.Add(buttonPosition12, 1, 2);
            tableLayoutPanelBoard.Controls.Add(buttonPosition02, 0, 2);
            tableLayoutPanelBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanelBoard.Location = new System.Drawing.Point(0, 75);
            tableLayoutPanelBoard.Name = "tableLayoutPanelBoard";
            tableLayoutPanelBoard.RowCount = 3;
            tableLayoutPanelBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            tableLayoutPanelBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            tableLayoutPanelBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            tableLayoutPanelBoard.Size = new System.Drawing.Size(335, 260);
            tableLayoutPanelBoard.TabIndex = 5;
            tableLayoutPanelBoard.Visible = false;
            // 
            // buttonPosition00
            // 
            buttonPosition00.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonPosition00.Location = new System.Drawing.Point(13, 13);
            buttonPosition00.Margin = new System.Windows.Forms.Padding(10);
            buttonPosition00.Name = "buttonPosition00";
            buttonPosition00.Size = new System.Drawing.Size(86, 61);
            buttonPosition00.TabIndex = 0;
            buttonPosition00.UseVisualStyleBackColor = true;
            buttonPosition00.Click += buttonPosition_Click;
            // 
            // buttonPosition10
            // 
            buttonPosition10.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonPosition10.Location = new System.Drawing.Point(122, 13);
            buttonPosition10.Margin = new System.Windows.Forms.Padding(10);
            buttonPosition10.Name = "buttonPosition10";
            buttonPosition10.Size = new System.Drawing.Size(86, 61);
            buttonPosition10.TabIndex = 1;
            buttonPosition10.UseVisualStyleBackColor = true;
            buttonPosition10.Click += buttonPosition_Click;
            // 
            // buttonPosition20
            // 
            buttonPosition20.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonPosition20.Location = new System.Drawing.Point(231, 13);
            buttonPosition20.Margin = new System.Windows.Forms.Padding(10);
            buttonPosition20.Name = "buttonPosition20";
            buttonPosition20.Size = new System.Drawing.Size(91, 61);
            buttonPosition20.TabIndex = 2;
            buttonPosition20.UseVisualStyleBackColor = true;
            buttonPosition20.Click += buttonPosition_Click;
            // 
            // buttonPosition01
            // 
            buttonPosition01.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonPosition01.Location = new System.Drawing.Point(13, 97);
            buttonPosition01.Margin = new System.Windows.Forms.Padding(10);
            buttonPosition01.Name = "buttonPosition01";
            buttonPosition01.Size = new System.Drawing.Size(86, 61);
            buttonPosition01.TabIndex = 3;
            buttonPosition01.UseVisualStyleBackColor = true;
            buttonPosition01.Click += buttonPosition_Click;
            // 
            // buttonPosition11
            // 
            buttonPosition11.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonPosition11.Location = new System.Drawing.Point(122, 97);
            buttonPosition11.Margin = new System.Windows.Forms.Padding(10);
            buttonPosition11.Name = "buttonPosition11";
            buttonPosition11.Size = new System.Drawing.Size(86, 61);
            buttonPosition11.TabIndex = 4;
            buttonPosition11.UseVisualStyleBackColor = true;
            buttonPosition11.Click += buttonPosition_Click;
            // 
            // buttonPosition21
            // 
            buttonPosition21.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonPosition21.Location = new System.Drawing.Point(231, 97);
            buttonPosition21.Margin = new System.Windows.Forms.Padding(10);
            buttonPosition21.Name = "buttonPosition21";
            buttonPosition21.Size = new System.Drawing.Size(91, 61);
            buttonPosition21.TabIndex = 5;
            buttonPosition21.UseVisualStyleBackColor = true;
            buttonPosition21.Click += buttonPosition_Click;
            // 
            // buttonPosition22
            // 
            buttonPosition22.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonPosition22.Location = new System.Drawing.Point(231, 181);
            buttonPosition22.Margin = new System.Windows.Forms.Padding(10);
            buttonPosition22.Name = "buttonPosition22";
            buttonPosition22.Size = new System.Drawing.Size(91, 66);
            buttonPosition22.TabIndex = 6;
            buttonPosition22.UseVisualStyleBackColor = true;
            buttonPosition22.Click += buttonPosition_Click;
            // 
            // buttonPosition12
            // 
            buttonPosition12.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonPosition12.Location = new System.Drawing.Point(122, 181);
            buttonPosition12.Margin = new System.Windows.Forms.Padding(10);
            buttonPosition12.Name = "buttonPosition12";
            buttonPosition12.Size = new System.Drawing.Size(86, 66);
            buttonPosition12.TabIndex = 7;
            buttonPosition12.UseVisualStyleBackColor = true;
            buttonPosition12.Click += buttonPosition_Click;
            // 
            // buttonPosition02
            // 
            buttonPosition02.Dock = System.Windows.Forms.DockStyle.Fill;
            buttonPosition02.Location = new System.Drawing.Point(13, 181);
            buttonPosition02.Margin = new System.Windows.Forms.Padding(10);
            buttonPosition02.Name = "buttonPosition02";
            buttonPosition02.Size = new System.Drawing.Size(86, 66);
            buttonPosition02.TabIndex = 8;
            buttonPosition02.UseVisualStyleBackColor = true;
            buttonPosition02.Click += buttonPosition_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(335, 335);
            Controls.Add(tableLayoutPanelBoard);
            Controls.Add(panelConfigGame);
            MinimumSize = new System.Drawing.Size(351, 374);
            Name = "MainForm";
            Text = "Gra \"Kółko i krzyżyk\"";
            panelConfigGame.ResumeLayout(false);
            panelConfigGame.PerformLayout();
            tableLayoutPanelBoard.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelConfigGame;
        private System.Windows.Forms.Label labelWhoStartGame;
        private System.Windows.Forms.ComboBox comboBoxWhoStartGame;
        private System.Windows.Forms.Button buttonNewGame;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBoard;
        private System.Windows.Forms.Button buttonPosition00;
        private System.Windows.Forms.Button buttonPosition10;
        private System.Windows.Forms.Button buttonPosition20;
        private System.Windows.Forms.Button buttonPosition01;
        private System.Windows.Forms.Button buttonPosition11;
        private System.Windows.Forms.Button buttonPosition21;
        private System.Windows.Forms.Button buttonPosition22;
        private System.Windows.Forms.Button buttonPosition12;
        private System.Windows.Forms.Button buttonPosition02;
    }
}

