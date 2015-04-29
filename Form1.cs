using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life
{
    public partial class LifeBox : Form
    {
        World world;

        public LifeBox()
        {
            InitializeComponent();
            world = new World(pictureBox.Width, pictureBox.Height);       
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!PauseBox.Checked)
                world.update();

            pictureBox.Refresh();
            
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {

            world.draw(e.Graphics);
        }       

        private void pictureBox_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            Point coordinates = click.Location;

            world.spawn(coordinates.Y / 2, coordinates.X / 2);
        }

        private void MenuBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MenuBox.Checked)
            {
                PauseBox.Visible = true;
                Reset.Visible = true;
                AdvancedMenu.Visible = true;
                Randomize.Visible = true;
                RandomChance.Visible = true;
                ChanceExplanation.Visible = true;
            }
            else
            {
                PauseBox.Visible = false;
                Reset.Visible = false;
                AdvancedMenu.Visible = false;
                Randomize.Visible = false;
                RandomChance.Visible = false;
                ChanceExplanation.Visible = false;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            world.reset();
        }

        private void AdvancedMenu_CheckedChanged(object sender, EventArgs e)
        {
            if (AdvancedMenu.Checked)
            {
                pictureBox.Visible = false;
                Introduction.Visible = true;
                Shapes.Visible = true;
                ListBox.Visible = true;
                ShapeCoordinates.Visible = true;
                CreateShape.Visible = true;
                CreateCustomShape.Visible = true;
                CustomShapeCoordinates.Visible = true;
                CustomShape.Visible = true;

                PauseBox.Checked = true;
            }
            else
            {
                pictureBox.Visible = true;
                Introduction.Visible = false;
                Shapes.Visible = false;
                ListBox.Visible = false;
                ShapeCoordinates.Visible = false;
                CreateShape.Visible = false;
                CreateCustomShape.Visible = false;
                CustomShapeCoordinates.Visible = false;
                CustomShape.Visible = false;
                LWSSDirection.Visible = false;
                GliderDirection.Visible = false;
            }
        } 

        private void CreateShape_Click(object sender, EventArgs e)
        {
            int direction = 0;

            if (ShapeCoordinates.Lines.Count() == 2)
            {
                int[] coords = new int[] { Convert.ToInt32(ShapeCoordinates.Lines[0]), Convert.ToInt32(ShapeCoordinates.Lines[1]) };
                int shapeIndex = ListBox.SelectedIndex;
                
                if(shapeIndex == 7 )
                    direction = GliderDirection.SelectedIndex;
                else if(shapeIndex == 8)
                    direction = LWSSDirection.SelectedIndex;

                world.createShape(shapeIndex, coords, direction);
            }
        }

        private void PauseBox_CheckedChanged(object sender, EventArgs e)
        {
            if (AdvancedMenu.Checked)
                PauseBox.Checked = true;
        }

        private void CreateCustomShape_Click(object sender, EventArgs e)
        {
            if (ShapeCoordinates.Lines.Count() > 2 && ShapeCoordinates.Lines.Count() % 2 == 0)
            {
                List<int[]> coords = new List<int[]>();

                for (int i = 0; i < ShapeCoordinates.Lines.Count() - 1; i++)
                {
                    coords.Add(new int[] { Convert.ToInt32(ShapeCoordinates.Lines[i]), Convert.ToInt32(ShapeCoordinates.Lines[i + 1]) });
                }

                foreach (int[] coord in coords)
                {
                    world.spawn(coord[0], coord[1]);
                }
            }
        }

        private void Randomize_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(RandomChance.Lines[0]) <= 100 && Convert.ToInt32(RandomChance.Lines[0]) >= 0)
                world.randomize(Convert.ToInt32(RandomChance.Lines[0]));
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex == 7)
            {
                LWSSDirection.Visible = false;
                GliderDirection.Visible = true;
            }
            else if (ListBox.SelectedIndex == 8)
            {
                LWSSDirection.Visible = true;
                GliderDirection.Visible = false;
            }
            else
            {
                LWSSDirection.Visible = false;
                GliderDirection.Visible = false;
            }
        }

       


    }
}
