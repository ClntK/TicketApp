
namespace Wk3_Form_To_Display_Ticket_Info
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
            this.btn_Purchase = new System.Windows.Forms.Button();
            this.lbl_EventType = new System.Windows.Forms.Label();
            this.cmbo_EventSelect = new System.Windows.Forms.ComboBox();
            this.lbl_Display = new System.Windows.Forms.Label();
            this.btn_ViewEvent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Purchase
            // 
            this.btn_Purchase.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_Purchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Purchase.ForeColor = System.Drawing.Color.Goldenrod;
            this.btn_Purchase.Location = new System.Drawing.Point(211, 300);
            this.btn_Purchase.Name = "btn_Purchase";
            this.btn_Purchase.Size = new System.Drawing.Size(147, 44);
            this.btn_Purchase.TabIndex = 0;
            this.btn_Purchase.Text = "Purchase";
            this.btn_Purchase.UseVisualStyleBackColor = false;
            this.btn_Purchase.Click += new System.EventHandler(this.btn_Purchase_Click);
            // 
            // lbl_EventType
            // 
            this.lbl_EventType.AutoSize = true;
            this.lbl_EventType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EventType.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl_EventType.Location = new System.Drawing.Point(207, 23);
            this.lbl_EventType.Name = "lbl_EventType";
            this.lbl_EventType.Size = new System.Drawing.Size(151, 29);
            this.lbl_EventType.TabIndex = 3;
            this.lbl_EventType.Text = "Event Type:";
            // 
            // cmbo_EventSelect
            // 
            this.cmbo_EventSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbo_EventSelect.FormattingEnabled = true;
            this.cmbo_EventSelect.ItemHeight = 20;
            this.cmbo_EventSelect.Items.AddRange(new object[] {
            "Sporting Event",
            "Theatre Event",
            "Convention Event"});
            this.cmbo_EventSelect.Location = new System.Drawing.Point(53, 64);
            this.cmbo_EventSelect.Name = "cmbo_EventSelect";
            this.cmbo_EventSelect.Size = new System.Drawing.Size(463, 28);
            this.cmbo_EventSelect.TabIndex = 2;
            this.cmbo_EventSelect.Text = "Select an event type to view available tickets..";
            // 
            // lbl_Display
            // 
            this.lbl_Display.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Display.AutoSize = true;
            this.lbl_Display.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Display.ForeColor = System.Drawing.Color.White;
            this.lbl_Display.Location = new System.Drawing.Point(150, 100);
            this.lbl_Display.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.lbl_Display.Name = "lbl_Display";
            this.lbl_Display.Size = new System.Drawing.Size(0, 17);
            this.lbl_Display.TabIndex = 1;
            // 
            // btn_ViewEvent
            // 
            this.btn_ViewEvent.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_ViewEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ViewEvent.ForeColor = System.Drawing.Color.Goldenrod;
            this.btn_ViewEvent.Location = new System.Drawing.Point(211, 251);
            this.btn_ViewEvent.Name = "btn_ViewEvent";
            this.btn_ViewEvent.Size = new System.Drawing.Size(147, 43);
            this.btn_ViewEvent.TabIndex = 4;
            this.btn_ViewEvent.Text = "View Event";
            this.btn_ViewEvent.UseVisualStyleBackColor = false;
            this.btn_ViewEvent.Click += new System.EventHandler(this.btn_ViewEvent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(569, 356);
            this.Controls.Add(this.btn_ViewEvent);
            this.Controls.Add(this.lbl_EventType);
            this.Controls.Add(this.cmbo_EventSelect);
            this.Controls.Add(this.lbl_Display);
            this.Controls.Add(this.btn_Purchase);
            this.MaximumSize = new System.Drawing.Size(587, 403);
            this.MinimumSize = new System.Drawing.Size(587, 403);
            this.Name = "Form1";
            this.Text = "School Event Ticket Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Purchase;
        private System.Windows.Forms.Label lbl_EventType;
        private System.Windows.Forms.ComboBox cmbo_EventSelect;
        private System.Windows.Forms.Label lbl_Display;
        private System.Windows.Forms.Button btn_ViewEvent;
    }
}

