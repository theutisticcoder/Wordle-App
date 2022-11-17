using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

public class Form1 : Form {

	Button back = new Button();
	Button a = new Button();
	Button b = new Button();
	Button c = new Button();
	Button d = new Button();
	Button e = new Button();
	Button f = new Button();
	Button g = new Button();
	Button h = new Button();
	Button i = new Button();
	Button j = new Button();
	Button k = new Button();
	Button l = new Button();
	Button m = new Button();
	Button n = new Button();
	Button o = new Button();
	Button p = new Button();
	Button q = new Button();
	Button r = new Button();
	Button s = new Button();
	Button t = new Button();
	Button u = new Button();
	Button v = new Button();
	Button w = new Button();
	Button x = new Button();
	Button y = new Button();
	Button z = new Button();
   string l1 = "s";
     string l2 = "p";
    string l3 = "e";
    string l4 = "c";
    string l5 = "k";
	string answer = "speck";
	string guess = String.Empty;
	string dictionarypath = "dictionary.txt";
	TextBox g11 = new TextBox();
	TextBox g12 = new TextBox();
	TextBox g13 = new TextBox();
	TextBox g14 = new TextBox();
	TextBox g15 = new TextBox();
	TextBox g21 = new TextBox();
	TextBox g22 = new TextBox();
	TextBox g23 = new TextBox();
	TextBox g24 = new TextBox();
	TextBox g25 = new TextBox();
	TextBox g31 = new TextBox();
	TextBox g32 = new TextBox();
	TextBox g33 = new TextBox();
	TextBox g34 = new TextBox();
	TextBox g35 = new TextBox();
	TextBox g41 = new TextBox();
	TextBox g42 = new TextBox();
	TextBox g43 = new TextBox();
	TextBox g44 = new TextBox();
	TextBox g45 = new TextBox();
	TextBox g51 = new TextBox();
	TextBox g52 = new TextBox();
	TextBox g53 = new TextBox();
	TextBox g54 = new TextBox();
	TextBox g55 = new TextBox();
	TextBox g61 = new TextBox();
	TextBox g62 = new TextBox();
	TextBox g63 = new TextBox();
	TextBox g64 = new TextBox();
	TextBox g65 = new TextBox();
	System.Windows.Forms.Button submit1 = new System.Windows.Forms.Button();

	public Form1(){
			this.BackColor = Color.Gray;
		this.a.Height = 20;
		this.a.Width = 20;
		this.a.Text = "a";
		this.a.Location = new Point(0, 170);
		this.a.Click += new EventHandler(addLetter);
		this.Controls.Add(a);
		this.b.Height = 20;
		this.b.Width = 20;
		this.b.Text = "b";
		this.b.Location = new Point(20, 170);
		this.b.Click += new EventHandler(addLetter);
		this.Controls.Add(b);
		this.c.Height = 20;
		this.c.Width = 20;
		this.c.Text = "c";
		this.c.Location = new Point(40, 170);
		this.c.Click += new EventHandler(addLetter);
		this.Controls.Add(c);
		this.d.Height = 20;
		this.d.Width = 20;
		this.d.Text = "d";
		this.d.Location = new Point(60, 170);
		this.d.Click += new EventHandler(addLetter);
		this.Controls.Add(d);
		this.e.Height = 20;
		this.e.Width = 20;
		this.e.Text = "e";
		this.e.Location = new Point(80, 170);
		this.e.Click += new EventHandler(addLetter);
		this.Controls.Add(e);
		this.f.Height = 20;
		this.f.Width = 20;
		this.f.Text = "f";
		this.f.Location = new Point(100, 170);
		this.f.Click += new EventHandler(addLetter);
		this.Controls.Add(f);
		this.g.Height = 20;
		this.g.Width = 20;
		this.g.Text = "g";
		this.g.Location = new Point(0, 190);
		this.g.Click += new EventHandler(addLetter);
		this.Controls.Add(g);
		this.h.Height = 20;
		this.h.Width = 20;
		this.h.Text = "h";
		this.h.Location = new Point(20, 190);
		this.h.Click += new EventHandler(addLetter);
		this.Controls.Add(h);
		this.Height = 300;
		this.Width = 130;
		this.i.Height = 20;
		this.i.Width = 20;
		this.i.Text = "i";
		this.i.Location = new Point(40, 190);
		this.i.Click += new EventHandler(addLetter);
		this.Controls.Add(i);
		this.j.Height = 20;
		this.j.Width = 20;
		this.j.Text = "j";
		this.j.Location = new Point(60, 190);
		this.j.Click += new EventHandler(addLetter);
		this.Controls.Add(j);
		this.k.Height = 20;
		this.k.Width = 20;
		this.k.Text = "k";
		this.k.Location = new Point(80, 190);
		this.k.Click += new EventHandler(addLetter);
		this.Controls.Add(k);
		this.l.Height = 20;
		this.l.Width = 20;
		this.l.Text = "l";
		this.l.Location = new Point(100, 190);
		this.l.Click += new EventHandler(addLetter);
		this.Controls.Add(l);
		this.m.Height = 20;
		this.m.Width = 20;
		this.m.Text = "m";
		this.m.Location = new Point(0, 210);
		this.m.Click += new EventHandler(addLetter);
		this.Controls.Add(m);
		this.n.Height = 20;
		this.n.Width = 20;
		this.n.Text = "n";
		this.n.Location = new Point(20, 210);
		this.n.Click += new EventHandler(addLetter);
		this.Controls.Add(n);
		this.o.Height = 20;
		this.o.Width = 20;
		this.o.Text = "o";
		this.o.Location = new Point(40, 210);
		this.o.Click += new EventHandler(addLetter);
		this.Controls.Add(o);
		this.p.Height = 20;
		this.p.Width = 20;
		this.p.Text = "p";
		this.p.Location = new Point(60, 210);
		this.p.Click += new EventHandler(addLetter);
		this.Controls.Add(p);
		this.Height = 300;
		this.Width = 130;
			this.q.Height = 20;
		this.q.Width = 20;
		this.q.Text = "q";
		this.q.Location = new Point(80, 210);
		this.q.Click += new EventHandler(addLetter);
		this.Controls.Add(q);
		this.r.Height = 20;
		this.r.Width = 20;
		this.r.Text = "r";
		this.r.Location = new Point(100, 210);
		this.r.Click += new EventHandler(addLetter);
		this.Controls.Add(r);
		this.s.Height = 20;
		this.s.Width = 20;
		this.s.Text = "s";
		this.s.Location = new Point(0, 230);
		this.s.Click += new EventHandler(addLetter);
		this.Controls.Add(s);
		this.t.Height = 20;
		this.t.Width = 20;
		this.t.Text = "t";
		this.t.Location = new Point(20, 230);
		this.t.Click += new EventHandler(addLetter);
		this.Controls.Add(t);
		this.u.Height = 20;
		this.u.Width = 20;
		this.u.Text = "u";
		this.u.Location = new Point(40, 230);
		this.u.Click += new EventHandler(addLetter);
		this.Controls.Add(u);
		this.v.Height = 20;
		this.v.Width = 20;
		this.v.Text = "v";
		this.v.Location = new Point(60, 230);
		this.v.Click += new EventHandler(addLetter);
		this.Controls.Add(v);
		this.w.Height = 20;
		this.w.Width = 20;
		this.w.Text = "w";
		this.w.Location = new Point(80, 230);
		this.w.Click += new EventHandler(addLetter);
		this.Controls.Add(w);
		this.x.Height = 20;
		this.x.Width = 20;
		this.x.Text = "x";
		this.x.Location = new Point(100, 230);
		this.x.Click += new EventHandler(addLetter);
		this.Controls.Add(x);
		this.Height = 300;
		this.Width = 130;
		this.y.Height = 20;
		this.y.Width = 20;
		this.y.Text = "y";
		this.y.Location = new Point(0, 250);
		this.y.Click += new EventHandler(addLetter);
		this.Controls.Add(y);
		this.z.Height = 20;
		this.z.Width = 20;
		this.z.Text = "z";
		this.z.Location = new Point(20, 250);
		this.z.Click += new EventHandler(addLetter);
		this.Controls.Add(z);
		this.back.Height = 20;
		this.back.Width = 80;
		this.back.Location = new Point(40, 250);
		this.back.Text = "Delete";
		this.back.Click += new EventHandler(backadd);
		this.Controls.Add(back);
		this.Height = 350;
		this.Width = 125;
			MessageBox.Show("Welcome to Wordle App. This is like normal wordle, but more! There is one thing added: dark gray boxes now mean that the letter is used too many times. Also, you now can type in any letter box during your guess. This means that you now create a strategy easier. Unfortunately, you must click on the next box manually or press tab to go to type the next letter. Thank you for playing Wordle App!");

		this.g11.SetBounds(10, 10, 20, 20);
		this.g11.MaxLength = 1;
		this.g11.Enter += new EventHandler(Letter);
		this.Controls.Add(g11);

		this.g12.SetBounds(30, 10, 20, 20);
		this.g12.MaxLength = 1;
this.g12.Enter += new EventHandler(Letter);
		this.Controls.Add(g12);

		this.g13.SetBounds(50, 10, 20, 20);
		this.g13.MaxLength = 1;
this.g13.Enter += new EventHandler(Letter);
		this.Controls.Add(g13);

		this.g14.SetBounds(70, 10, 20, 20);
		this.g14.MaxLength = 1;
this.g14.Enter += new EventHandler(Letter);
		this.Controls.Add(g14);
		
		this.g15.SetBounds(90, 10, 20, 20);
		this.g15.MaxLength = 1;
this.g15.Enter += new EventHandler(Letter);
		this.Controls.Add(g15);
		
		this.submit1.SetBounds(0, 150, 120, 20);
		this.submit1.Text = "Check";
		this.submit1.Click += new EventHandler(check1);
		this.Controls.Add(submit1);
	
	}
	void check1(object sender, EventArgs e){
				string g1 = g11.Text + g12.Text + g13.Text + g14.Text + g15.Text;
		if((g1).Length == 5){
			if(File.ReadAllText(dictionarypath).Contains(g1)){
		g11.ReadOnly = true;
		g12.ReadOnly = true;
		g13.ReadOnly = true;
		g14.ReadOnly = true;
		g15.ReadOnly = true;
		if(g1 == answer){
			g11.BackColor = Color.Green;
			g12.BackColor = Color.Green;
			g13.BackColor = Color.Green;
			g14.BackColor = Color.Green;
			g15.BackColor = Color.Green;
		}
		else{
			
			for(int i = 0; i < answer.Length; i++){
				int count = 0;
				foreach(char c in g1){
					if(c == answer[i]) count ++;
				}
				 if(count == 1){
					 
					 if(g11.Text.Contains(l1)){
						g11.BackColor = Color.Green;
					}
					  else if(g12.Text.Contains(l1) && l1 != l2){
						g12.BackColor = Color.Yellow;
					}
					  else if(g13.Text.Contains(l1) && l1 != l3){
						g13.BackColor = Color.Yellow;
					}
					  else if(g14.Text.Contains(l1) && l1 != l4){
						g14.BackColor = Color.Yellow;
					}
						else if(g15.Text.Contains(l1) && l1 != l5){
						g15.BackColor = Color.Yellow;
					}

					
					 if(g12.Text.Contains(l2)){
						g12.BackColor = Color.Green;
					}
					 else if(g11.Text.Contains(l2) && l1 != l2){
						g11.BackColor = Color.Yellow;
					}
					 else if(g13.Text.Contains(l2) && l2 != l3){
						g13.BackColor = Color.Yellow;
					}
					 else if(g14.Text.Contains(l2) && l2 != l4){
						g14.BackColor = Color.Yellow;
					}
					 else if(g15.Text.Contains(l2) && l2 != l5){
						g15.BackColor = Color.Yellow;
					}

					
					  if(g13.Text.Contains(l3)){
						g13.BackColor = Color.Green;
					}
				 		else if(g11.Text.Contains(l3)){
						g11.BackColor = Color.Yellow;
					}
					  else if(g12.Text.Contains(l3) && l2 != l3){
						g12.BackColor = Color.Yellow;
					}
					  else if(g14.Text.Contains(l3) && l4 != l3){
						g14.BackColor = Color.Yellow;
					}
					  else if(g15.Text.Contains(l3) && l3 != l5){
						g15.BackColor = Color.Yellow;
					}


					  if(g14.Text.Contains(l4)){
						g14.BackColor = Color.Green;
					}
					  else if(g11.Text.Contains(l4)){
						g11.BackColor = Color.Yellow;
					}
					  else if(g12.Text.Contains(l4)){
						g12.BackColor = Color.Yellow;
					}
					  else if(g13.Text.Contains(l4)){
						g13.BackColor = Color.Yellow;
					}
					  else if(g15.Text.Contains(l4)){
						g15.BackColor = Color.Yellow;
					}


					  if(g15.Text.Contains(l5)){
						g15.BackColor = Color.Green;
					}
					  else if(g11.Text.Contains(l5)){
						g11.BackColor = Color.Yellow;
					}
					  else if(g12.Text.Contains(l5)){
						g12.BackColor = Color.Yellow;
					}
					  else if(g13.Text.Contains(l5)){
						g13.BackColor = Color.Yellow;
					}
					  else if(g14.Text.Contains(l5) && l4 != l5){
						g14.BackColor = Color.Yellow;
					}
			}
				 else if(count > 1){
					if(g11.Text.Contains(l1)){
						if(g12.Text.Contains(l1)){
							g12.BackColor = Color.Gray;
						}
						if(g13.Text.Contains(l1)){
							g13.BackColor = Color.Gray;
						}
						if(g14.Text.Contains(l1)){
							g14.BackColor = Color.Gray;
						}
						if(g15.Text.Contains(l1)){
							g15.BackColor = Color.Gray;
						}
						}
				else if(g12.Text.Contains(l2)){
						if(g11.Text.Contains(l2)){
							g11.BackColor = Color.Gray;
						}
						if(g13.Text.Contains(l2)){
							g13.BackColor = Color.Gray;
						}
						if(g14.Text.Contains(l2)){
							g14.BackColor = Color.Gray;
						}
						if(g15.Text.Contains(l2)){
							g15.BackColor = Color.Gray;
						}
				}
				
				else if(g13.Text.Contains(l3)){
						if(g11.Text.Contains(l3)){
							g11.BackColor = Color.Gray;
						}
						if(g12.Text.Contains(l3)){
							g12.BackColor = Color.Gray;
						}
						if(g14.Text.Contains(l3)){
							g14.BackColor = Color.Gray;
						}
						if(g15.Text.Contains(l3)){
							g15.BackColor = Color.Gray;
						}
						
				}
				else if(g14.Text.Contains(l4)){
						if(g11.Text.Contains(l4)){
							g11.BackColor = Color.Gray;
						}
						if(g13.Text.Contains(l4)){
							g13.BackColor = Color.Gray;
						}
						if(g13.Text.Contains(l4)){
							g13.BackColor = Color.Gray;
						}
						if(g15.Text.Contains(l4)){
							g15.BackColor = Color.Gray;
						}
				}
				else if(g15.Text.Contains(l5)){
						if(g11.Text.Contains(l5)){
							g11.BackColor = Color.Gray;
						}
						if(g12.Text.Contains(l5)){
							g12.BackColor = Color.Gray;
						}
						if(g13.Text.Contains(l5)){
							g13.BackColor = Color.Gray;
						}
						if(g14.Text.Contains(l5)){
							g14.BackColor = Color.Gray;
						}
				}
				 else if(g11.BackColor == Color.Yellow){
						if(g12.Text.Contains(answer[i])){
							g12.BackColor = Color.Gray;
						}
						if(g13.Text.Contains(answer[i])){
							g13.BackColor = Color.Gray;
						}
						if(g14.Text.Contains(answer[i])){
							g14.BackColor = Color.Gray;
						}
						if(g15.Text.Contains(answer[i])){
							g15.BackColor = Color.Gray;
						}
				}
				else if(g12.BackColor == Color.Yellow){
						if(g11.Text.Contains(answer[i])){
							g11.BackColor = Color.Gray;
						}
						if(g13.Text.Contains(answer[i])){
							g13.BackColor = Color.Gray;
						}
						if(g14.Text.Contains(answer[i])){
							g14.BackColor = Color.Gray;
						}
						if(g15.Text.Contains(answer[i])){
							g15.BackColor = Color.Gray;
						}
				}
				else if(g13.BackColor == Color.Yellow){
						if(g11.Text.Contains(answer[i])){
							g11.BackColor = Color.Gray;
						}
						if(g12.Text.Contains(answer[i])){
							g12.BackColor = Color.Gray;
						}
						if(g14.Text.Contains(answer[i])){
							g14.BackColor = Color.Gray;
						}
						if(g15.Text.Contains(answer[i])){
							g15.BackColor = Color.Gray;
						}
						
				}
				else if(g14.BackColor == Color.Yellow){
						if(g11.Text.Contains(answer[i])){
							g11.BackColor = Color.Gray;
						}
						if(g13.Text.Contains(answer[i])){
							g13.BackColor = Color.Gray;
						}
						if(g13.Text.Contains(answer[i])){
							g13.BackColor = Color.Gray;
						}
						if(g15.Text.Contains(answer[i])){
							g15.BackColor = Color.Gray;
						}
				}
				else if(g15.BackColor == Color.Yellow){
						if(g11.Text.Contains(answer[i])){
							g11.BackColor = Color.Gray;
						}
						if(g12.Text.Contains(answer[i])){
							g12.BackColor = Color.Gray;
						}
						if(g13.Text.Contains(answer[i])){
							g13.BackColor = Color.Gray;
						}
						if(g14.Text.Contains(answer[i])){
							g14.BackColor = Color.Gray;
						}
				}
			}
		Round2();
		}
			}
			}
		}
}
	void Round2(){
		
		this.g21.SetBounds(10, 30, 20, 20);
		this.g21.Enter += new EventHandler(Letter);
		this.g21.MaxLength = 1;
		this.Controls.Add(g21);

		this.g22.SetBounds(30, 30, 20, 20);
				this.g22.Enter += new EventHandler(Letter);
		this.g22.MaxLength = 1;
		this.Controls.Add(g22);
		this.g23.Enter += new EventHandler(Letter);
		this.g23.SetBounds(50, 30, 20, 20);
		this.g23.MaxLength = 1;
		this.Controls.Add(g23);
		this.g24.Enter += new EventHandler(Letter);
		this.g24.SetBounds(70, 30, 20, 20);
		this.g24.MaxLength = 1;
		this.Controls.Add(g24);
				this.g25.Enter += new EventHandler(Letter);
		this.g25.SetBounds(90, 30, 20, 20);
		this.g25.MaxLength = 1;
		this.Controls.Add(g25);
		
		this.submit1.SetBounds(0, 150, 130, 20);
		this.submit1.Text = "Check";
		this.submit1.Click -= check1;
		this.submit1.Click += new EventHandler(check2);
		this.Controls.Add(submit1);
		}
	
		void check2(object sender, EventArgs e){
			string g2 = g21.Text + g22.Text + g23.Text + g24.Text + g25.Text;
			if((g2).Length == 5){
			if(File.ReadAllText(dictionarypath).Contains(g2)){
		g21.ReadOnly = true;
		g22.ReadOnly = true;
		g23.ReadOnly = true;
		g24.ReadOnly = true;
		g25.ReadOnly = true;
			if(g2 == answer){
			g21.BackColor = Color.Green;
			g22.BackColor = Color.Green;
			g23.BackColor = Color.Green;
			g24.BackColor = Color.Green;
			g25.BackColor = Color.Green;
		}
		else{
		
					for(int i = 0; i < answer.Length; i++){
				int count = 0;
				foreach(char c in g2){
					if(c == answer[i]) count ++;
				}
				 if(count == 1){
					 if(g21.Text.Contains(l1)){
						g21.BackColor = Color.Green;
					}
					  else if(g22.Text.Contains(l1) && l1 != l2){
						g22.BackColor = Color.Yellow;
					}
					  else if(g23.Text.Contains(l1) && l1 != l3){
						g23.BackColor = Color.Yellow;
					}
					  else if(g24.Text.Contains(l1) && l1 != l4){
						g24.BackColor = Color.Yellow;
					}
						else if(g25.Text.Contains(l1) && l1 != l5){
						g25.BackColor = Color.Yellow;
					}

					
					 if(g22.Text.Contains(l2)){
						g22.BackColor = Color.Green;
					}
					 else if(g21.Text.Contains(l2) && l2 != l1){
						g21.BackColor = Color.Yellow;
					}
					 else if(g23.Text.Contains(l2) && l2 != l3){
						g23.BackColor = Color.Yellow;
					}
					 else if(g24.Text.Contains(l2) && l2 != l4){
						g24.BackColor = Color.Yellow;
					}
					 else if(g25.Text.Contains(l2) && l2 != l5){
						g25.BackColor = Color.Yellow;
					}

					
					  if(g23.Text.Contains(l3)){
						g23.BackColor = Color.Green;
					}
				 		else if(g21.Text.Contains(l3) && l3 != l1){
						g21.BackColor = Color.Yellow;
					}
					  else if(g22.Text.Contains(l3) && l2 != l3){
						g22.BackColor = Color.Yellow;
					}
					  else if(g24.Text.Contains(l3) && l3 != l4){
						g24.BackColor = Color.Yellow;
					}
					  else if(g25.Text.Contains(l3) && l3 != l5){
						g25.BackColor = Color.Yellow;
					}


					  if(g24.Text.Contains(l4)){
						g24.BackColor = Color.Green;
					}
					  else if(g21.Text.Contains(l4) && l4 != l1){
						g21.BackColor = Color.Yellow;
					}
					  else if(g22.Text.Contains(l4) && l4 != l2){
						g22.BackColor = Color.Yellow;
					}
					  else if(g23.Text.Contains(l4) && l4 != l3){
						g23.BackColor = Color.Yellow;
					}
					  else if(g25.Text.Contains(l4) && l4 != l5){
						g25.BackColor = Color.Yellow;
					}


					  if(g25.Text.Contains(l5)){
						g25.BackColor = Color.Green;
					}
					  else if(g21.Text.Contains(l5) && l5 != l1){
						g21.BackColor = Color.Yellow;
					}
					  else if(g22.Text.Contains(l5) && l5 != l2){
						g22.BackColor = Color.Yellow;
					}
					  else if(g23.Text.Contains(l5)&& l5 != l3){
						g23.BackColor = Color.Yellow;
					}
					  else if(g24.Text.Contains(l5)&& l5 != l4){
						g24.BackColor = Color.Yellow;
					}
			}
				 else if(count > 1){
					if(g21.Text.Contains(l1)){
						if(g22.Text.Contains(l1)){
							g22.BackColor = Color.Gray;
						}
						if(g23.Text.Contains(l1)){
							g23.BackColor = Color.Gray;
						}
						if(g24.Text.Contains(l1)){
							g24.BackColor = Color.Gray;
						}
						if(g25.Text.Contains(l1)){
							g25.BackColor = Color.Gray;
						}
						}
				else if(g22.Text.Contains(l2)){
						if(g21.Text.Contains(l2)){
							g21.BackColor = Color.Gray;
						}
						if(g23.Text.Contains(l2)){
							g23.BackColor = Color.Gray;
						}
						if(g24.Text.Contains(l2)){
							g24.BackColor = Color.Gray;
						}
						if(g25.Text.Contains(l2)){
							g25.BackColor = Color.Gray;
						}
				}
				
				else if(g23.Text.Contains(l3)){
						if(g21.Text.Contains(l3)){
							g21.BackColor = Color.Gray;
						}
						if(g22.Text.Contains(l3)){
							g22.BackColor = Color.Gray;
						}
						if(g24.Text.Contains(l3)){
							g24.BackColor = Color.Gray;
						}
						if(g25.Text.Contains(l3)){
							g25.BackColor = Color.Gray;
						}
						
				}
				else if(g24.Text.Contains(l4)){
						if(g21.Text.Contains(l4)){
							g21.BackColor = Color.Gray;
						}
						if(g23.Text.Contains(l4)){
							g23.BackColor = Color.Gray;
						}
						if(g23.Text.Contains(l4)){
							g23.BackColor = Color.Gray;
						}
						if(g25.Text.Contains(l4)){
							g25.BackColor = Color.Gray;
						}
				}
				else if(g25.Text.Contains(l5)){
						if(g21.Text.Contains(l5)){
							g21.BackColor = Color.Gray;
						}
						if(g22.Text.Contains(l5)){
							g22.BackColor = Color.Gray;
						}
						if(g23.Text.Contains(l5)){
							g23.BackColor = Color.Gray;
						}
						if(g24.Text.Contains(l5)){
							g24.BackColor = Color.Gray;
						}
				}
				 else if(g21.BackColor == Color.Yellow){
						if(g22.Text.Contains(answer[i])){
							g22.BackColor = Color.Gray;
						}
						if(g23.Text.Contains(answer[i])){
							g23.BackColor = Color.Gray;
						}
						if(g24.Text.Contains(answer[i])){
							g24.BackColor = Color.Gray;
						}
						if(g25.Text.Contains(answer[i])){
							g25.BackColor = Color.Gray;
						}
				}
				else if(g22.BackColor == Color.Yellow){
						if(g21.Text.Contains(answer[i])){
							g21.BackColor = Color.Gray;
						}
						if(g23.Text.Contains(answer[i])){
							g23.BackColor = Color.Gray;
						}
						if(g24.Text.Contains(answer[i])){
							g24.BackColor = Color.Gray;
						}
						if(g25.Text.Contains(answer[i])){
							g25.BackColor = Color.Gray;
						}
				}
				else if(g23.BackColor == Color.Yellow){
						if(g21.Text.Contains(answer[i])){
							g21.BackColor = Color.Gray;
						}
						if(g22.Text.Contains(answer[i])){
							g22.BackColor = Color.Gray;
						}
						if(g24.Text.Contains(answer[i])){
							g24.BackColor = Color.Gray;
						}
						if(g25.Text.Contains(answer[i])){
							g25.BackColor = Color.Gray;
						}
						
				}
				else if(g24.BackColor == Color.Yellow){
						if(g21.Text.Contains(answer[i])){
							g21.BackColor = Color.Gray;
						}
						if(g22.Text.Contains(answer[i])){
							g23.BackColor = Color.Gray;
						}
						if(g22.Text.Contains(answer[i])){
							g23.BackColor = Color.Gray;
						}
						if(g25.Text.Contains(answer[i])){
							g25.BackColor = Color.Gray;
						}
				}
				else if(g25.BackColor == Color.Yellow){
						if(g21.Text.Contains(answer[i])){
							g21.BackColor = Color.Gray;
						}
						if(g22.Text.Contains(answer[i])){
							g22.BackColor = Color.Gray;
						}
						if(g23.Text.Contains(answer[i])){
							g23.BackColor = Color.Gray;
						}
						if(g24.Text.Contains(answer[i])){
							g24.BackColor = Color.Gray;
						}
				}
			}
		Round3();
            }
		}
		}
			}
		}
		void Round3(){
		this.g31.SetBounds(10, 50, 20, 20);
		this.g31.MaxLength = 1;
					this.g31.Enter += new EventHandler(Letter);
		this.Controls.Add(g31);
					this.g32.Enter += new EventHandler(Letter);
		this.g32.SetBounds(30, 50, 20, 20);
		this.g32.MaxLength = 1;
		this.Controls.Add(g32);
					this.g33.Enter += new EventHandler(Letter);
		this.g33.SetBounds(50, 50, 20, 20);
		this.g33.MaxLength = 1;
		this.Controls.Add(g33);
					this.g34.Enter += new EventHandler(Letter);
		this.g34.SetBounds(70, 50, 20, 20);
		this.g34.MaxLength = 1;
		this.Controls.Add(g34);
							this.g35.Enter += new EventHandler(Letter);
		this.g35.SetBounds(90, 50, 20, 20);
		this.g35.MaxLength = 1;
		this.Controls.Add(g35);
		
		this.submit1.SetBounds(0, 150, 130, 20);
		this.submit1.Text = "Check";
		this.submit1.Click -= check2;
		this.submit1.Click += new EventHandler(check3);
		this.Controls.Add(submit1);
		}
		void check3(object sender, EventArgs e){
				string g3 = g31.Text + g32.Text + g33.Text + g34.Text + g35.Text;
			if(g3.Length == 5){
			if(File.ReadAllText(dictionarypath).Contains(g3)){
			g31.ReadOnly = true;
			g32.ReadOnly = true;
			g33.ReadOnly = true;
			g34.ReadOnly = true;
			g35.ReadOnly = true;
			if(g3 == answer){
			g31.BackColor = Color.Green;
			g32.BackColor = Color.Green;
			g33.BackColor = Color.Green;
			g34.BackColor = Color.Green;
			g35.BackColor = Color.Green;
			}
			else{
						for(int i = 0; i < answer.Length; i++){
				int count = 0;
				foreach(char c in g3){
					if(c == answer[i]) count ++;
				}
				 if(count == 1){
					 if(g31.Text.Contains(l1)){
						g31.BackColor = Color.Green;
					}
					  else if(g32.Text.Contains(l1) && l1 != l2){
						g32.BackColor = Color.Yellow;
					}
					  else if(g33.Text.Contains(l1) && l1 != l3){
						g33.BackColor = Color.Yellow;
					}
					  else if(g34.Text.Contains(l1) && l1 != l4){
						g34.BackColor = Color.Yellow;
					}
						else if(g35.Text.Contains(l1) && l1 != l5){
						g35.BackColor = Color.Yellow;
					}

					
					 if(g32.Text.Contains(l2)){
						g32.BackColor = Color.Green;
					}
					 else if(g31.Text.Contains(l2) && l2 != l1){
						g31.BackColor = Color.Yellow;
					}
					 else if(g33.Text.Contains(l2) && l2 != l3){
						g33.BackColor = Color.Yellow;
					}
					 else if(g34.Text.Contains(l2) && l2 != l4){
						g34.BackColor = Color.Yellow;
					}
					 else if(g35.Text.Contains(l2) && l2 != l5){
						g35.BackColor = Color.Yellow;
					}

					
					  if(g33.Text.Contains(l3)){
						g33.BackColor = Color.Green;
					}
				 		else if(g31.Text.Contains(l3) && l3 != l1){
						g31.BackColor = Color.Yellow;
					}
					  else if(g32.Text.Contains(l3) && l3 != l2){
						g32.BackColor = Color.Yellow;
					}
					  else if(g34.Text.Contains(l3) && l3 != l4){
						g34.BackColor = Color.Yellow;
					}
					  else if(g35.Text.Contains(l3) && l3 != l5){
						g35.BackColor = Color.Yellow;
					}


					  if(g34.Text.Contains(l4)){
						g34.BackColor = Color.Green;
					}
					  else if(g31.Text.Contains(l4) && l4 != l1){
						g31.BackColor = Color.Yellow;
					}
					  else if(g32.Text.Contains(l4) && l4 != l2){
						g32.BackColor = Color.Yellow;
					}
					  else if(g33.Text.Contains(l4) && l4 != l3){
						g33.BackColor = Color.Yellow;
					}
					  else if(g35.Text.Contains(l4) && l4 != l5){
						g35.BackColor = Color.Yellow;
					}


					  if(g35.Text.Contains(l5)){
						g35.BackColor = Color.Green;
					}
					  else if(g31.Text.Contains(l5)&& l5 != l1){
						g31.BackColor = Color.Yellow;
					}
					  else if(g32.Text.Contains(l5) && l5 != l2){
						g32.BackColor = Color.Yellow;
					}
					  else if(g33.Text.Contains(l5)&& l5 != l3){
						g33.BackColor = Color.Yellow;
					}
					  else if(g34.Text.Contains(l5)&& l5 != l4){
						g34.BackColor = Color.Yellow;
					}
			}
				 else if(count > 1){
					if(g31.Text.Contains(l1)){
						if(g32.Text.Contains(l1)){
							g32.BackColor = Color.Gray;
						}
						if(g33.Text.Contains(l1)){
							g33.BackColor = Color.Gray;
						}
						if(g34.Text.Contains(l1)){
							g34.BackColor = Color.Gray;
						}
						if(g35.Text.Contains(l1)){
							g35.BackColor = Color.Gray;
						}
						}
				else if(g32.Text.Contains(l2)){
						if(g31.Text.Contains(l2)){
							g31.BackColor = Color.Gray;
						}
						if(g33.Text.Contains(l2)){
							g33.BackColor = Color.Gray;
						}
						if(g34.Text.Contains(l2)){
							g34.BackColor = Color.Gray;
						}
						if(g35.Text.Contains(l2)){
							g35.BackColor = Color.Gray;
						}
				}
				
				else if(g33.Text.Contains(l3)){
						if(g31.Text.Contains(l3)){
							g31.BackColor = Color.Gray;
						}
						if(g32.Text.Contains(l3)){
							g32.BackColor = Color.Gray;
						}
						if(g34.Text.Contains(l3)){
							g34.BackColor = Color.Gray;
						}
						if(g35.Text.Contains(l3)){
							g35.BackColor = Color.Gray;
						}
						
				}
				else if(g34.Text.Contains(l4)){
						if(g31.Text.Contains(l4)){
							g31.BackColor = Color.Gray;
						}
						if(g33.Text.Contains(l4)){
							g33.BackColor = Color.Gray;
						}
						if(g33.Text.Contains(l4)){
							g33.BackColor = Color.Gray;
						}
						if(g35.Text.Contains(l4)){
							g35.BackColor = Color.Gray;
						}
				}
				else if(g35.Text.Contains(l5)){
						if(g31.Text.Contains(l5)){
							g31.BackColor = Color.Gray;
						}
						if(g32.Text.Contains(l5)){
							g32.BackColor = Color.Gray;
						}
						if(g33.Text.Contains(l5)){
							g33.BackColor = Color.Gray;
						}
						if(g34.Text.Contains(l5)){
							g34.BackColor = Color.Gray;
						}
				}
				 else if(g31.BackColor == Color.Yellow){
						if(g32.Text.Contains(answer[i])){
							g32.BackColor = Color.Gray;
						}
						if(g33.Text.Contains(answer[i])){
							g33.BackColor = Color.Gray;
						}
						if(g34.Text.Contains(answer[i])){
							g34.BackColor = Color.Gray;
						}
						if(g35.Text.Contains(answer[i])){
							g35.BackColor = Color.Gray;
						}
				}
				else if(g32.BackColor == Color.Yellow){
						if(g31.Text.Contains(answer[i])){
							g31.BackColor = Color.Gray;
						}
						if(g33.Text.Contains(answer[i])){
							g33.BackColor = Color.Gray;
						}
						if(g34.Text.Contains(answer[i])){
							g34.BackColor = Color.Gray;
						}
						if(g35.Text.Contains(answer[i])){
							g35.BackColor = Color.Gray;
						}
				}
				else if(g33.BackColor == Color.Yellow){
						if(g31.Text.Contains(answer[i])){
							g31.BackColor = Color.Gray;
						}
						if(g32.Text.Contains(answer[i])){
							g32.BackColor = Color.Gray;
						}
						if(g34.Text.Contains(answer[i])){
							g34.BackColor = Color.Gray;
						}
						if(g35.Text.Contains(answer[i])){
							g35.BackColor = Color.Gray;
						}
						
				}
				else if(g34.BackColor == Color.Yellow){
						if(g31.Text.Contains(answer[i])){
							g31.BackColor = Color.Gray;
						}
						if(g32.Text.Contains(answer[i])){
							g33.BackColor = Color.Gray;
						}
						if(g32.Text.Contains(answer[i])){
							g33.BackColor = Color.Gray;
						}
						if(g35.Text.Contains(answer[i])){
							g35.BackColor = Color.Gray;
						}
				}
				else if(g35.BackColor == Color.Yellow){
						if(g31.Text.Contains(answer[i])){
							g31.BackColor = Color.Gray;
						}
						if(g32.Text.Contains(answer[i])){
							g32.BackColor = Color.Gray;
						}
						if(g33.Text.Contains(answer[i])){
							g33.BackColor = Color.Gray;
						}
						if(g34.Text.Contains(answer[i])){
							g34.BackColor = Color.Gray;
						}
				}
			}
            }
		Round4();
			}
			}
			}
	}
		void Round4(){
		
		this.g41.SetBounds(10, 70, 20, 20);
								this.g41.Enter += new EventHandler(Letter);
		this.g41.MaxLength = 1;
		this.Controls.Add(g41);
								this.g42.Enter += new EventHandler(Letter);
		this.g42.SetBounds(30, 70, 20, 20);
		this.g42.MaxLength = 1;
		this.Controls.Add(g42);

		this.g43.SetBounds(50, 70, 20, 20);
								this.g43.Enter += new EventHandler(Letter);
		this.g43.MaxLength = 1;
		this.Controls.Add(g43);
								this.g44.Enter += new EventHandler(Letter);
		this.g44.SetBounds(70, 70, 20, 20);
		this.g44.MaxLength = 1;
		this.Controls.Add(g44);
										this.g45.Enter += new EventHandler(Letter);
		this.g45.SetBounds(90, 70, 20, 20);
		this.g45.MaxLength = 1;
		this.Controls.Add(g45);
		
		this.submit1.SetBounds(0, 150, 130, 20);
		this.submit1.Text = "Check";
		this.submit1.Click -= check3;
		this.submit1.Click += new EventHandler(check4);
		this.Controls.Add(submit1);
		}
		void check4(object sender, EventArgs e){
							string g4 = g41.Text + g42.Text + g43.Text + g44.Text + g45.Text;
			if(g4.Length == 5){
if(File.ReadAllText(dictionarypath).Contains(g4)){
			g41.ReadOnly = true;
			g42.ReadOnly = true;
			g43.ReadOnly = true;
			g44.ReadOnly = true;
			g45.ReadOnly = true;
			if(g4 == answer){
			g41.BackColor = Color.Green;
			g42.BackColor = Color.Green;
			g43.BackColor = Color.Green;
			g44.BackColor = Color.Green;
			g45.BackColor = Color.Green;
			}
			else{
							for(int i = 0; i < answer.Length; i++){
				int count = 0;
				foreach(char c in g4){
					if(c == answer[i]) count++;
				}
				 if(count == 1){
					 if(g41.Text.Contains(l1)){
						g41.BackColor = Color.Green;
					}
					  else if(g42.Text.Contains(l1) && l1 != l2){
						g42.BackColor = Color.Yellow;
					}
					  else if(g43.Text.Contains(l1) && l2 != l3){
						g43.BackColor = Color.Yellow;
					}
					  else if(g44.Text.Contains(l1) && l1 != l4){
						g44.BackColor = Color.Yellow;
					}
						else if(g45.Text.Contains(l1)&& l1 != l5){
						g45.BackColor = Color.Yellow;
					}

					
					 if(g42.Text.Contains(l2)){
						g42.BackColor = Color.Green;
					}
					 else if(g41.Text.Contains(l2) && l2 != l1){
						g41.BackColor = Color.Yellow;
					}
					 else if(g43.Text.Contains(l2)&& l2 != l3){
						g43.BackColor = Color.Yellow;
					}
					 else if(g44.Text.Contains(l2) && l2 != l4){
						g44.BackColor = Color.Yellow;
					}
					 else if(g45.Text.Contains(l2) && l2 != l5){
						g45.BackColor = Color.Yellow;
					}

					
					  if(g43.Text.Contains(l3)){
						g43.BackColor = Color.Green;
					}
				 		else if(g41.Text.Contains(l3) && l3 != l1){
						g41.BackColor = Color.Yellow;
					}
					  else if(g42.Text.Contains(l3)&& l2 != l3){
						g42.BackColor = Color.Yellow;
					}
					  else if(g44.Text.Contains(l3)&& l3 != l4){
						g44.BackColor = Color.Yellow;
					}
					  else if(g45.Text.Contains(l3)&& l5 != l3){
						g45.BackColor = Color.Yellow;
					}


					  if(g44.Text.Contains(l4)){
						g44.BackColor = Color.Green;
					}
					  else if(g41.Text.Contains(l4)&& l1 != l4){
						g41.BackColor = Color.Yellow;
					}
					  else if(g42.Text.Contains(l4)&& l2 != l4){
						g42.BackColor = Color.Yellow;
					}
					  else if(g43.Text.Contains(l4)&& l3 != l4){
						g43.BackColor = Color.Yellow;
					}
					  else if(g45.Text.Contains(l4)&& l5 != l4){
						g45.BackColor = Color.Yellow;
						}
					 
					  if(g45.Text.Contains(l5)){
						g45.BackColor = Color.Green;
					}
					  else if(g41.Text.Contains(l5)&& l5 != l1){
						g41.BackColor = Color.Yellow;
					}
					  else if(g42.Text.Contains(l5)&& l5 != l2){
						g42.BackColor = Color.Yellow;
					}
					  else if(g43.Text.Contains(l5)&& l5 != l3){
						g43.BackColor = Color.Yellow;
					}
					  else if(g44.Text.Contains(l5)&& l5 != l4){
						g44.BackColor = Color.Yellow;
					}
			}
				 else if(count > 1){
					if(g41.Text.Contains(l1)){
						if(g42.Text.Contains(l1)){
							g42.BackColor = Color.Gray;
						}
						if(g43.Text.Contains(l1)){
							g43.BackColor = Color.Gray;
						}
						if(g44.Text.Contains(l1)){
							g44.BackColor = Color.Gray;
						}
						if(g45.Text.Contains(l1)){
							g45.BackColor = Color.Gray;
						}
						}
				else if(g42.Text.Contains(l2)){
						if(g41.Text.Contains(l2)){
							g41.BackColor = Color.Gray;
						}
						if(g43.Text.Contains(l2)){
							g43.BackColor = Color.Gray;
						}
						if(g44.Text.Contains(l2)){
							g44.BackColor = Color.Gray;
						}
						if(g45.Text.Contains(l2)){
							g45.BackColor = Color.Gray;
						}
				}
				
				else if(g43.Text.Contains(l3)){
						if(g41.Text.Contains(l3)){
							g41.BackColor = Color.Gray;
						}
						if(g42.Text.Contains(l3)){
							g42.BackColor = Color.Gray;
						}
						if(g44.Text.Contains(l3)){
							g44.BackColor = Color.Gray;
						}
						if(g45.Text.Contains(l3)){
							g45.BackColor = Color.Gray;
						}
						
				}
				else if(g44.Text.Contains(l4)){
						if(g41.Text.Contains(l4)){
							g41.BackColor = Color.Gray;
						}
						if(g43.Text.Contains(l4)){
							g43.BackColor = Color.Gray;
						}
						if(g43.Text.Contains(l4)){
							g43.BackColor = Color.Gray;
						}
						if(g45.Text.Contains(l4)){
							g45.BackColor = Color.Gray;
						}
				}
				else if(g45.Text.Contains(l5)){
						if(g41.Text.Contains(l5)){
							g41.BackColor = Color.Gray;
						}
						if(g42.Text.Contains(l5)){
							g42.BackColor = Color.Gray;
						}
						if(g43.Text.Contains(l5)){
							g43.BackColor = Color.Gray;
						}
						if(g44.Text.Contains(l5)){
							g44.BackColor = Color.Gray;
						}
				}
				 else if(g41.BackColor == Color.Yellow){
						if(g42.Text.Contains(answer[i])){
							g42.BackColor = Color.Gray;
						}
						if(g43.Text.Contains(answer[i])){
							g43.BackColor = Color.Gray;
						}
						if(g44.Text.Contains(answer[i])){
							g44.BackColor = Color.Gray;
						}
						if(g45.Text.Contains(answer[i])){
							g45.BackColor = Color.Gray;
						}
				}
				else if(g42.BackColor == Color.Yellow){
						if(g41.Text.Contains(answer[i])){
							g41.BackColor = Color.Gray;
						}
						if(g43.Text.Contains(answer[i])){
							g43.BackColor = Color.Gray;
						}
						if(g44.Text.Contains(answer[i])){
							g44.BackColor = Color.Gray;
						}
						if(g45.Text.Contains(answer[i])){
							g45.BackColor = Color.Gray;
						}
				}
				else if(g43.BackColor == Color.Yellow){
						if(g41.Text.Contains(answer[i])){
							g41.BackColor = Color.Gray;
						}
						if(g42.Text.Contains(answer[i])){
							g42.BackColor = Color.Gray;
						}
						if(g44.Text.Contains(answer[i])){
							g44.BackColor = Color.Gray;
						}
						if(g45.Text.Contains(answer[i])){
							g45.BackColor = Color.Gray;
						}
						
				}
				else if(g44.BackColor == Color.Yellow){
						if(g41.Text.Contains(answer[i])){
							g41.BackColor = Color.Gray;
						}
						if(g42.Text.Contains(answer[i])){
							g43.BackColor = Color.Gray;
						}
						if(g42.Text.Contains(answer[i])){
							g43.BackColor = Color.Gray;
						}
						if(g45.Text.Contains(answer[i])){
							g45.BackColor = Color.Gray;
						}
				}
				else if(g45.BackColor == Color.Yellow){
						if(g41.Text.Contains(answer[i])){
							g41.BackColor = Color.Gray;
						}
						if(g42.Text.Contains(answer[i])){
							g42.BackColor = Color.Gray;
						}
						if(g43.Text.Contains(answer[i])){
							g43.BackColor = Color.Gray;
						}
						if(g44.Text.Contains(answer[i])){
							g44.BackColor = Color.Gray;
						}
				}
			}
            }
			Round5();
			}
		}
}
		}
		void Round5(){
		this.g51.SetBounds(10, 90, 20, 20);
											this.g51.Enter += new EventHandler(Letter);
		this.g51.MaxLength = 1;
		this.Controls.Add(g51);
											this.g52.Enter += new EventHandler(Letter);
		this.g52.SetBounds(30, 90, 20, 20);
		this.g52.MaxLength = 1;
		this.Controls.Add(g52);
											this.g53.Enter += new EventHandler(Letter);
		this.g53.SetBounds(50, 90, 20, 20);
		this.g53.MaxLength = 1;
		this.Controls.Add(g53);
											this.g54.Enter += new EventHandler(Letter);
		this.g54.SetBounds(70, 90, 20, 20);
		this.g54.MaxLength = 1;
		this.Controls.Add(g54);
				this.g55.Enter += new EventHandler(Letter);
		this.g55.SetBounds(90, 90, 20, 20);
		this.g55.MaxLength = 1;
		this.Controls.Add(g55);
		
		this.submit1.SetBounds(0, 150, 130, 20);
		this.submit1.Text = "Check";
		this.submit1.Click -= check4;
		this.submit1.Click += new EventHandler(check5);
		this.Controls.Add(submit1);
		}
		void check5(object sender, EventArgs e){
											string g5 = g51.Text + g52.Text + g53.Text + g54.Text + g55.Text;

			if(g5.Length == 5){
			if(File.ReadAllText(dictionarypath).Contains(g5)){
			g51.ReadOnly = true;
			g52.ReadOnly = true;
			g53.ReadOnly = true;
			g54.ReadOnly = true;
			g55.ReadOnly = true;
			if(g5 == answer){
			g51.BackColor = Color.Green;
			g52.BackColor = Color.Green;
			g53.BackColor = Color.Green;
			g54.BackColor = Color.Green;
			g55.BackColor = Color.Green;

			}
			else{
						for(int i = 0; i < answer.Length; i++){
				int count = 0;
				foreach(char c in g5){
					if(c == answer[i]) count ++;
				}
				 if(count == 1){
					 if(g51.Text.Contains(l1)){
						g51.BackColor = Color.Green;
					}
					  else if(g52.Text.Contains(l1)&& l1 != l2){
						g52.BackColor = Color.Yellow;
					}
					  else if(g53.Text.Contains(l1)&& l1 != l3){
						g53.BackColor = Color.Yellow;
					}
					  else if(g54.Text.Contains(l1)&& l1 != l4){
						g54.BackColor = Color.Yellow;
					}
						else if(g55.Text.Contains(l1)&& l1 != l5){
						g55.BackColor = Color.Yellow;
					}

					
					 if(g52.Text.Contains(l2)){
						g52.BackColor = Color.Green;
					}
					 else if(g51.Text.Contains(l2) && l2 != l1){
						g51.BackColor = Color.Yellow;
					}
					 else if(g53.Text.Contains(l2) && l2 != l3){
						g53.BackColor = Color.Yellow;
					}
					 else if(g54.Text.Contains(l2) && l2 != l4){
						g54.BackColor = Color.Yellow;
					}
					 else if(g55.Text.Contains(l2) && l2 != l5){
						g55.BackColor = Color.Yellow;
					}

					
					  if(g53.Text.Contains(l3)){
						g53.BackColor = Color.Green;
					}
				 		else if(g51.Text.Contains(l3) && l3 != l1){
						g51.BackColor = Color.Yellow;
					}
					  else if(g52.Text.Contains(l3) && l3 != l2){
						g52.BackColor = Color.Yellow;
					}
					  else if(g54.Text.Contains(l3) && l3 != l4){
						g54.BackColor = Color.Yellow;
					}
					  else if(g55.Text.Contains(l3) && l3 != l5){
						g55.BackColor = Color.Yellow;
					}


					  if(g54.Text.Contains(l4)){
						g54.BackColor = Color.Green;
					}
					  else if(g51.Text.Contains(l4) && l4 != l1){
						g51.BackColor = Color.Yellow;
					}
					  else if(g52.Text.Contains(l4) && l4 != l2){
						g52.BackColor = Color.Yellow;
					}
					  else if(g53.Text.Contains(l4) && l4 != l3){
						g53.BackColor = Color.Yellow;
					}
					  else if(g55.Text.Contains(l4) && l4 != l5){
						g55.BackColor = Color.Yellow;
					}


					  if(g55.Text.Contains(l5)){
						g55.BackColor = Color.Green;
					}
					  else if(g51.Text.Contains(l5) && l5 != l1){
						g51.BackColor = Color.Yellow;
					}
					  else if(g52.Text.Contains(l5) && l5 != l2){
						g52.BackColor = Color.Yellow;
					}
					  else if(g53.Text.Contains(l5) && l5 != l3){
						g53.BackColor = Color.Yellow;
					}
					  else if(g54.Text.Contains(l5) && l5 != l4){
						g54.BackColor = Color.Yellow;
					}
			}
				 else if(count > 1){
					if(g51.Text.Contains(l1)){
						if(g52.Text.Contains(l1)){
							g52.BackColor = Color.Gray;
						}
						if(g53.Text.Contains(l1)){
							g53.BackColor = Color.Gray;
						}
						if(g54.Text.Contains(l1)){
							g54.BackColor = Color.Gray;
						}
						if(g55.Text.Contains(l1)){
							g55.BackColor = Color.Gray;
						}
						}
				else if(g52.Text.Contains(l2)){
						if(g51.Text.Contains(l2)){
							g51.BackColor = Color.Gray;
						}
						if(g53.Text.Contains(l2)){
							g53.BackColor = Color.Gray;
						}
						if(g54.Text.Contains(l2)){
							g54.BackColor = Color.Gray;
						}
						if(g55.Text.Contains(l2)){
							g55.BackColor = Color.Gray;
						}
				}
				
				else if(g53.Text.Contains(l3)){
						if(g51.Text.Contains(l3)){
							g51.BackColor = Color.Gray;
						}
						if(g52.Text.Contains(l3)){
							g52.BackColor = Color.Gray;
						}
						if(g54.Text.Contains(l3)){
							g54.BackColor = Color.Gray;
						}
						if(g55.Text.Contains(l3)){
							g55.BackColor = Color.Gray;
						}
						
				}
				else if(g54.Text.Contains(l4)){
						if(g51.Text.Contains(l4)){
							g51.BackColor = Color.Gray;
						}
						if(g53.Text.Contains(l4)){
							g53.BackColor = Color.Gray;
						}
						if(g53.Text.Contains(l4)){
							g53.BackColor = Color.Gray;
						}
						if(g55.Text.Contains(l4)){
							g55.BackColor = Color.Gray;
						}
				}
				else if(g55.Text.Contains(l5)){
						if(g51.Text.Contains(l5)){
							g51.BackColor = Color.Gray;
						}
						if(g52.Text.Contains(l5)){
							g52.BackColor = Color.Gray;
						}
						if(g53.Text.Contains(l5)){
							g53.BackColor = Color.Gray;
						}
						if(g54.Text.Contains(l5)){
							g54.BackColor = Color.Gray;
						}
				}
				 else if(g51.BackColor == Color.Yellow){
						if(g52.Text.Contains(answer[i])){
							g52.BackColor = Color.Gray;
						}
						if(g53.Text.Contains(answer[i])){
							g53.BackColor = Color.Gray;
						}
						if(g54.Text.Contains(answer[i])){
							g54.BackColor = Color.Gray;
						}
						if(g55.Text.Contains(answer[i])){
							g55.BackColor = Color.Gray;
						}
				}
				else if(g52.BackColor == Color.Yellow){
						if(g51.Text.Contains(answer[i])){
							g51.BackColor = Color.Gray;
						}
						if(g53.Text.Contains(answer[i])){
							g53.BackColor = Color.Gray;
						}
						if(g54.Text.Contains(answer[i])){
							g54.BackColor = Color.Gray;
						}
						if(g55.Text.Contains(answer[i])){
							g55.BackColor = Color.Gray;
						}
				}
				else if(g53.BackColor == Color.Yellow){
						if(g51.Text.Contains(answer[i])){
							g51.BackColor = Color.Gray;
						}
						if(g52.Text.Contains(answer[i])){
							g52.BackColor = Color.Gray;
						}
						if(g54.Text.Contains(answer[i])){
							g54.BackColor = Color.Gray;
						}
						if(g55.Text.Contains(answer[i])){
							g55.BackColor = Color.Gray;
						}
						
				}
				else if(g54.BackColor == Color.Yellow){
						if(g51.Text.Contains(answer[i])){
							g51.BackColor = Color.Gray;
						}
						if(g52.Text.Contains(answer[i])){
							g53.BackColor = Color.Gray;
						}
						if(g52.Text.Contains(answer[i])){
							g53.BackColor = Color.Gray;
						}
						if(g55.Text.Contains(answer[i])){
							g55.BackColor = Color.Gray;
						}
				}
				else if(g55.BackColor == Color.Yellow){
						if(g51.Text.Contains(answer[i])){
							g51.BackColor = Color.Gray;
						}
						if(g52.Text.Contains(answer[i])){
							g52.BackColor = Color.Gray;
						}
						if(g53.Text.Contains(answer[i])){
							g53.BackColor = Color.Gray;
						}
						if(g54.Text.Contains(answer[i])){
							g54.BackColor = Color.Gray;
						}
				}
			}

            }
		Round6();

			}
			}
}

	}
		void Round6(){
							this.g61.Enter += new EventHandler(Letter);
		this.g61.SetBounds(10, 110, 20, 20);
		this.g61.MaxLength = 1;
		this.Controls.Add(g61);
							this.g62.Enter += new EventHandler(Letter);
		this.g62.SetBounds(30, 110, 20, 20);
		this.g62.MaxLength = 1;
		this.Controls.Add(g62);
							this.g63.Enter += new EventHandler(Letter);
		this.g63.SetBounds(50, 110, 20, 20);
		this.g63.MaxLength = 1;
		this.Controls.Add(g63);
							this.g64.Enter += new EventHandler(Letter);
		this.g64.SetBounds(70, 110, 20, 20);
		this.g64.MaxLength = 1;
		this.Controls.Add(g64);
									this.g65.Enter += new EventHandler(Letter);
		this.g65.SetBounds(90, 110, 20, 20);
		this.g65.MaxLength = 1;
		this.Controls.Add(g65);
		
		this.submit1.SetBounds(0, 150, 130, 20);
		this.submit1.Text = "Check";
		this.submit1.Click -= check5;
		this.submit1.Click += new EventHandler(check6);
		this.Controls.Add(submit1);
		}
	
		void check6(object sender, EventArgs e){
			string g6 = g61.Text + g62.Text + g64.Text + g64.Text + g65.Text;
				if(g6.Length == 5){
			if(File.ReadAllText(dictionarypath).Contains(g6)){
			g61.ReadOnly = true;
			g62.ReadOnly = true;
			g63.ReadOnly = true;
			g64.ReadOnly = true;
			g65.ReadOnly = true;
			if(g6 == answer){
			g61.BackColor = Color.Green;
			g62.BackColor = Color.Green;
			g63.BackColor = Color.Green;
			g64.BackColor = Color.Green;
			g65.BackColor = Color.Green;

			}
			else{
				Label done = new Label();
				done.Text = "Sorry, but the word was: " + answer + ". \r\nGood job though!";
				done.Location = new Point(0, 270);
				done.Height = 120;
				done.Width = 120;
			Controls.Add(done);
			}
		}
				}
		}
	void addLetter(object sender, EventArgs e){
		if(g11.ReadOnly == true){
			if(g21.ReadOnly == true){
				if(g31.ReadOnly == true){
					if(g41.ReadOnly == true){
						if(g51.ReadOnly == true){
							if(g61.Text.Length < 1){
				g61.Text = (sender as Button).Text;
			}
			else if(g62.Text.Length < 1){
				g62.Text = (sender as Button).Text;
			}
				else if(g63.Text.Length < 1){
				g63.Text = (sender as Button).Text;
			}
				else if(g64.Text.Length < 1){
				g64.Text = (sender as Button).Text;
			}
				else{
				g65.Text = (sender as Button).Text;
			}
						}
						else{
							if(g51.Text.Length < 1){
				g51.Text = (sender as Button).Text;
			}
			else if(g52.Text.Length < 1){
				g52.Text = (sender as Button).Text;
			}
				else if(g53.Text.Length < 1){
				g53.Text = (sender as Button).Text;
			}
				else if(g54.Text.Length < 1){
				g54.Text = (sender as Button).Text;
			}
				else{
				g55.Text = (sender as Button).Text;
			}
						}
						}
						else{
							if(g41.Text.Length < 1){
				g41.Text = (sender as Button).Text;
			}
			else if(g42.Text.Length < 1){
				g42.Text = (sender as Button).Text;
			}
				else if(g43.Text.Length < 1){
				g43.Text = (sender as Button).Text;
			}
				else if(g44.Text.Length < 1){
				g44.Text = (sender as Button).Text;
			}
				else{
				g45.Text = (sender as Button).Text;
			}
						}
					}
					else{
						if(g31.Text.Length < 1){
				g31.Text = (sender as Button).Text;
			}
			else if(g32.Text.Length < 1){
				g32.Text = (sender as Button).Text;
			}
				else if(g33.Text.Length < 1){
				g33.Text = (sender as Button).Text;
			}
				else if(g34.Text.Length < 1){
				g34.Text = (sender as Button).Text;
			}
				else{
				g35.Text = (sender as Button).Text;
			}
		}
			}
		else{
			if(g21.Text.Length < 1){
				g21.Text = (sender as Button).Text;
			}
			else if(g22.Text.Length < 1){
				g22.Text = (sender as Button).Text;
			}
				else if(g23.Text.Length < 1){
				g23.Text = (sender as Button).Text;
			}
				else if(g24.Text.Length < 1){
				g24.Text = (sender as Button).Text;
			}
				else{
				g25.Text = (sender as Button).Text;
			}
	}
	}
		else{
			if(g11.Text.Length < 1){
				g11.Text = (sender as Button).Text;
			}
			else if(g12.Text.Length < 1){
				g12.Text = (sender as Button).Text;
			}
				else if(g13.Text.Length < 1){
				g13.Text = (sender as Button).Text;
			}
				else if(g14.Text.Length < 1){
				g14.Text = (sender as Button).Text;
			}
				else{
				g15.Text = (sender as Button).Text;
			}			
		}
}
		void backadd(object sender, EventArgs e){
		if(g11.ReadOnly == true){
			if(g21.ReadOnly == true){
				if(g31.ReadOnly == true){
					if(g41.ReadOnly == true){
						if(g51.ReadOnly == true){
							if(g65.Text.Length > 0){
				g65.Text = "";
			}
			else if(g64.Text.Length > 0){
				g64.Text = "";
			}
				else if(g63.Text.Length > 0){
				g63.Text = "";
			}
				else if(g62.Text.Length > 0){
				g62.Text = "";
			}
				else{
				g61.Text = "";
			}
						}
						else{
							if(g55.Text.Length > 0){
				g55.Text = "";
			}
			else if(g54.Text.Length > 0){
				g54.Text = "";
			}
				else if(g53.Text.Length > 0){
				g53.Text = "";
			}
				else if(g52.Text.Length > 0){
				g52.Text = "";
			}
				else{
				g51.Text = "";
			}
						}
						}
						else{
							if(g45.Text.Length > 0){
				g45.Text = "";
			}
			else if(g44.Text.Length > 0){
				g44.Text = "";
			}
				else if(g43.Text.Length > 0){
				g43.Text = "";
			}
				else if(g42.Text.Length > 0){
				g42.Text = "";
			}
				else{
				g41.Text = "";
			}
						}
					}
					else{
						if(g35.Text.Length > 0){
				g35.Text = "";
			}
			else if(g34.Text.Length > 0){
				g34.Text = "";
			}
				else if(g33.Text.Length > 0){
				g33.Text = "";
			}
				else if(g32.Text.Length > 0){
				g32.Text = "";
			}
				else{
				g31.Text = "";
			}
		}
			}
		else{
		if(g25.Text.Length > 0){
				g25.Text = "";
			}
			else if(g24.Text.Length > 0){
				g24.Text = "";
			}
				else if(g23.Text.Length > 0){
				g23.Text = "";
			}
				else if(g22.Text.Length > 0){
				g22.Text = "";
			}
				else{
				g21.Text = "";
			}
	}
	}
		else{
			if(g15.Text.Length > 0){
				g15.Text = "";
			}
			else if(g14.Text.Length > 0){
				g14.Text = "";
			}
				else if(g13.Text.Length > 0){
				g13.Text = "";
			}
				else if(g12.Text.Length > 0){
				g12.Text = "";
			}
				else{
				g11.Text = "";
			}	
		}
}
void Letter(object sender, EventArgs e){
}
	[STAThread]
	 	static void Main(){
		Application.Run(new Form1());
	}
}
