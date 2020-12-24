using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace WindowsFormsApplication6
{
    public partial class homepage : Form
    {
        private void create_plan()
        {
            body_panel();
            head_body("Plan");
            plan_page plan = new plan_page();
            plan.get_plan();
            create_plan_body(plan);

            add_footer();


        }
        private void create_plan_body(plan_page obj_plan)
        {
            Color text_color = Color.FromArgb(50, 50, 50);

            Panel plan_sub = create_flowpanel("plan_sub", over_controll.av_body_size_x, 200, Color.Transparent, over_controll.active_panel);
            over_controll.active_panel.Controls.Add(plan_sub);
            plan_sub.AutoSize = true;
            plan_sub.MaximumSize = new Size(0, 0);
            plan_sub.Padding = new Padding(0);

            Panel plan_body_all = create_flowpanel("plan_body_all", 1100, 200, Color.Transparent, plan_sub);
            plan_sub.Controls.Add(plan_body_all);


            for (int i = 0; i<3; i++)
            {
                Panel plan1_body = create_panel(i.ToString(), 350, 700, Color.Transparent, plan_body_all);
                plan_body_all.Controls.Add(plan1_body);
                Panel plan1 = create_flowpanel("1", 200, 200, Color.FromArgb(200, 200, 200), plan1_body);
                plan1_body.Controls.Add(plan1);
                plan1.Location = new Point(100, 10);
                plan1.AutoSize = true;
                plan1.MaximumSize = new Size(200, 0);
                Label name = create_label("name", obj_plan.name[i], 200, 30, Color.Transparent, text_color, plan1);
                plan1.Controls.Add(name);
                Label screen = create_label("screen", "Screen : " + obj_plan.screen[i], 200, 30, Color.Transparent, text_color, plan1);
                plan1.Controls.Add(screen);
                Label quality = create_label("name", "Quality : " + obj_plan.quality[i], 200, 30, Color.Transparent, text_color, plan1);
                plan1.Controls.Add(quality);
                Label price = create_label("name", obj_plan.price[i] + "$", 200, 30, Color.Transparent, text_color, plan1);
                plan1.Controls.Add(price);
                Button select = create_button(i.ToString(), "Select", 200, 30, text_color, Color.FromArgb(200, 200, 200), plan1);
                plan1.Controls.Add(select);
                select.Margin = new Padding(0);
                name.Font = new Font("Neuropolitical", 12, FontStyle.Bold);
                name.TextAlign = ContentAlignment.MiddleCenter;
                screen.Font = new Font("Neuropolitical", 12, FontStyle.Bold);
                screen.TextAlign = ContentAlignment.MiddleCenter;
                quality.Font = new Font("Neuropolitical", 12, FontStyle.Bold);
                quality.TextAlign = ContentAlignment.MiddleCenter;
                price.Font = new Font("Neuropolitical", 12, FontStyle.Bold);
                price.TextAlign = ContentAlignment.MiddleCenter;
                select.Font = new Font("Neuropolitical", 12, FontStyle.Bold);
                select.TextAlign = ContentAlignment.MiddleCenter;
                select.Click += (sender, EventArgs) => { plan_click(sender, EventArgs, obj_plan); };
            }
            Panel confirmation_body = create_flowpanel("confirmation_body", 1100, 700, Color.Transparent, plan_sub);
            plan_sub.Controls.Add(confirmation_body);
            Panel note = create_panel("note",1100,40,Color.Transparent, confirmation_body);
            confirmation_body.Controls.Add(note);
            Label note_text = create_label("note_text", "Note : This plan will be valid till end of the month", 1100, 40, Color.Transparent, Color.IndianRed, note);
            note.Controls.Add(note_text);
            note_text.Font = new Font("Neuropolitical", 10, FontStyle.Regular);

            Panel input = create_panel("input", 1100, 60, Color.Transparent, confirmation_body);
            confirmation_body.Controls.Add(input);
            Label input_label = create_label("input_label" ,"Card : ",80,40,Color.Transparent,text_color, input);
            input.Controls.Add(input_label);
            input_label.Location = new Point(20, 10);
            TextBox input_card = create_textbox("input_card","Card no",200,40,over_controll.color_background,Color.FromArgb(210,210,210), input);
            input.Controls.Add(input_card);
            input_card.Location = new Point(100, 10);
            input_card.Click += (sender, EventArgs) => { card_text_click(sender, EventArgs, obj_plan); };
            input_card.TextChanged += (sender, EventArgs) => { card_text_change(sender, EventArgs, obj_plan); };

            Panel purchase = create_panel("purchase", 1100, 60, Color.Transparent, confirmation_body);
            confirmation_body.Controls.Add(purchase);
            string x = "Select plan first";
            if(obj_plan.selected >= 0 )
            {
               x = "Purchase : " +  obj_plan.name[obj_plan.selected];
            }
            Button purchase_b = create_button("purchase",  x, 300, 50, text_color, Color.FromArgb(200, 200, 200), purchase);
            purchase.Controls.Add(purchase_b);
            purchase_b.Margin = new Padding(0);
            purchase_b.Click += (sender, EventArgs) => { purch_click(sender, EventArgs, obj_plan); };

            
        }

        protected void plan_click(object sender, EventArgs e, plan_page obj_plan)
        {
            Control botton = ((Control)sender);
            if (botton.ForeColor == over_controll.color_active)
            {
                change_purchase_button("Select plan first");
                obj_plan.selected = -1;
                botton.ForeColor = Color.FromArgb(200, 200, 200);
                return;
            }
            else
            {

                botton.ForeColor = over_controll.color_active;
                Control grand_grand_parent = botton.Parent.Parent.Parent; 
                foreach(Control b in grand_grand_parent.Controls)
                {
                    b.Controls[0].Controls[4].ForeColor = Color.FromArgb(200, 200, 200);
                }
                botton.ForeColor = over_controll.color_active;
                obj_plan.selected = Int32.Parse(botton.Name);
                string x = "Purchase : " + obj_plan.name[obj_plan.selected];

                change_purchase_button(x);

            }

        }
        protected void card_text_click(object sender, EventArgs e, plan_page obj_plan)
        {
            Control text = ((Control)sender);
            if(text.Text == "Card no")
            {
                text.Text = "";
                text.ForeColor = Color.FromArgb(50, 50, 50);
            }



        }
        protected void card_text_change(object sender, EventArgs e, plan_page obj_plan)
        {
            Control text = ((Control)sender);

            if (text.Text != "")
                obj_plan.purch_text = true;
            if (text.Text == "")
                obj_plan.purch_text = false;
        }
        
        private void change_purchase_button(string x )
        {
            foreach(Control a in over_controll.active_panel.Controls)
            {
                if(a.Name== "plan_sub")
                {
                    foreach (Control b in a.Controls)
                    {
                        if(b.Name== "confirmation_body")
                        {
                            foreach (Control c in b.Controls)
                                if(c.Name == "purchase")
                                {
                                    Button bu = (Button)c.Controls[0];
                                    bu.Text = x; 
                                }

                        }
                    }

                }
            }
        }
        protected void purch_click(object sender, EventArgs e, plan_page obj_plan)
        {

            if (obj_plan.selected != -1 && obj_plan.purch_text)
            {
                buy_plan(obj_plan);
                menubar_load();
                home_go_to();

            }


        }
        

    }
}
