namespace injector
{
	// Token: 0x02000009 RID: 9
	public partial class Help : global::System.Windows.Forms.Form
	{
		// Token: 0x06000073 RID: 115 RVA: 0x005AD8C0 File Offset: 0x005A24C0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x005AD904 File Offset: 0x005A2504
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			this.bunifuElipse3 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.bunifuDragControl1 = new global::Bunifu.Framework.UI.BunifuDragControl(this.components);
			this.bunifuElipse1 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			this.button3 = new global::System.Windows.Forms.Button();
			this.bunifuElipse2 = new global::Bunifu.Framework.UI.BunifuElipse(this.components);
			base.SuspendLayout();
			this.bunifuElipse3.ElipseRadius = 10;
			this.bunifuElipse3.TargetControl = this;
			this.bunifuDragControl1.Fixed = true;
			this.bunifuDragControl1.Horizontal = true;
			this.bunifuDragControl1.TargetControl = this;
			this.bunifuDragControl1.Vertical = true;
			this.bunifuElipse1.ElipseRadius = 10;
			this.button3.BackColor = global::System.Drawing.Color.FromArgb(22, 22, 22);
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button3.ForeColor = global::System.Drawing.Color.White;
			this.button3.Location = new global::System.Drawing.Point(541, 4);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(25, 25);
			this.button3.TabIndex = 45;
			this.button3.Text = "X";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.bunifuElipse2.ElipseRadius = 10;
			this.bunifuElipse2.TargetControl = this.button3;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(55, 55, 55);
			base.ClientSize = new global::System.Drawing.Size(571, 31);
			base.Controls.Add(this.button3);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Help";
			this.Text = "Help";
			base.Load += new global::System.EventHandler(this.Help_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x04000040 RID: 64
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000041 RID: 65
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse3;

		// Token: 0x04000042 RID: 66
		private global::Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;

		// Token: 0x04000043 RID: 67
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse1;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000045 RID: 69
		private global::Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
	}
}
