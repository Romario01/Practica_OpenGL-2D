using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace LinesPointsQuads
{
    public partial class Form1 : MetroForm
    {
        float x;
        float y;
        float x1;
        float y1;
        float t;
        byte ID_EVENT = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void glControl1_Load(object sender, EventArgs e)
        {
            OnLoad();
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            OnRenderFrame();
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           OnUpdateFrame();
        }

        void OnLoad()
        {

        }

        void OnUpdateFrame()
        {
           Painting();

        }

        void OnRenderFrame()
        {
            Painting();
      
        }

        void check_status(byte e)
        {
            if(e == 0)
            {
                rdaLinea.Checked = false;
                rdaPunto.Checked = false;
                rdaTriangulo.Checked = false;
                txtX.Text = "";
                txtY.Text = "";
                txtX.Focus();
            }
            if(e == 1)
            {
                rdaLinea.Checked = false;
                rdaPunto.Checked = false;
                rdaTriangulo.Checked = false;
                txtX.Text = "";
                txtY.Text = "";
                ID_EVENT = 0;
                txtX.Focus();
            }

        }
        void Painting()
        {
           if(ID_EVENT == 100)
            {
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            }
            if (rdaPunto.Checked == true)
            {
                if (ID_EVENT == 1)
                {
                    Vector2 v = new Vector2(x, y);
                    CreatePoint(v, 5);
                }
            }

            if (rdaLinea.Checked == true)
            {
                if (ID_EVENT == 2)
                {

                    CreateLine(new Vector2(x, y), new Vector2(x1, y1));

                }

            }

            if (rdaTriangulo.Checked == true)
            {
                if (ID_EVENT == 3)
                {
                    CreateTriangles(new Vector2(x - 0.2f, y), new Vector2(x, y + 0.2f), new Vector2(x + 0.2f, y));

                }

            }

            if (rdaCuadrado.Checked == true)
            {
                if (ID_EVENT == 4)
                {
                    //CreateQuad(new Vector2(0.4f, 0.4f), new Vector2(-0.4f, 0.4f), new Vector2(-0.4f, -0.4f), new Vector2(0.4f, -0.4f));
                    CreateQuad(new Vector2(x + 0.1f, y + 0.1f), new Vector2(x - 0.1f, y + 0.1f), new Vector2(x - 0.1f, y - 0.1f), new Vector2(x + 0.1f, y - 0.1f));
                }
            }

            if (rdaRec.Checked == true)
            {
                if (ID_EVENT == 5)
                {

                    //no mover los valores estaticos
                    CreateQuad(new Vector2(x, y), new Vector2(-t, y), new Vector2(-t, -y), new Vector2(x, -y));
                }

            }

            if (rdaCirculo.Checked == true)
            {
                if (ID_EVENT == 6)
                {
                    DrawCircle(x, y, t);
                }
                
            }
            glControl1.SwapBuffers();
        }

         void DrawCircle(float x, float y, float radius)
        {
            GL.Enable(EnableCap.Blend);
            GL.BlendFunc(BlendingFactorSrc.SrcAlpha, BlendingFactorDest.OneMinusSrcAlpha);
            GL.Begin(PrimitiveType.TriangleFan);
            GL.Color3(Color.FromArgb(metroTrackBar1.Value, metroTrackBar2.Value, metroTrackBar3.Value));

            GL.Vertex2(x, y);
            for (int i = 0; i < 360; i++)
            {
                GL.Vertex2(x + Math.Cos(i) * radius, y + Math.Sin(i) * radius);
            }

            GL.End();
            GL.Disable(EnableCap.Blend);
        }
        void CreatePoint(Vector2 position,float size)
        {
            
            GL.PointSize(size);
            GL.Begin(PrimitiveType.Points);
            GL.Color3(Color.FromArgb(metroTrackBar1.Value, metroTrackBar2.Value, metroTrackBar3.Value));
            GL.Vertex2(position);
            GL.End();
        }

        
        void CreateLine(Vector2 startPos,Vector2 endPos)
        {
            GL.Begin(PrimitiveType.Lines);
            GL.Color3(Color.FromArgb(metroTrackBar1.Value, metroTrackBar2.Value, metroTrackBar3.Value));
            GL.Vertex2(startPos);
            GL.Color3(Color.FromArgb(metroTrackBar1.Value, metroTrackBar2.Value, metroTrackBar3.Value));
            GL.Vertex2(endPos);
            GL.End();
        }
        void CreateTriangles(Vector2 point1, Vector2 point2,Vector2 point3)
        {
            GL.Begin(PrimitiveType.Triangles);
            GL.Color3(Color.FromArgb(metroTrackBar1.Value, metroTrackBar2.Value, metroTrackBar3.Value));
            GL.Vertex2(point1);
            GL.Color3(Color.FromArgb(metroTrackBar1.Value, metroTrackBar2.Value, metroTrackBar3.Value));
            GL.Vertex2(point2);
            GL.Color3(Color.FromArgb(metroTrackBar1.Value, metroTrackBar2.Value, metroTrackBar3.Value));
            GL.Vertex2(point3);
            GL.End();
        }
        void CreateQuad(Vector2 point1, Vector2 point2, Vector2 point3,Vector2 point4)
        {
            GL.Begin(PrimitiveType.Quads);
            GL.Color3(Color.FromArgb(metroTrackBar1.Value, metroTrackBar2.Value, metroTrackBar3.Value));
            GL.Vertex2(point1);
            GL.Vertex2(point2);
            GL.Vertex2(point3);
            GL.Vertex2(point4);
            GL.End();
        }

        private void metroTrackBar1_ValueChanged(object sender, EventArgs e)
        {
            metroTextBox1.Text = metroTrackBar1.Value.ToString();
        }

        private void metroTrackBar2_ValueChanged(object sender, EventArgs e)
        {
            metroTextBox2.Text = metroTrackBar2.Value.ToString();
        }

        private void metroTrackBar3_ValueChanged(object sender, EventArgs e)
        {
            metroTextBox3.Text = metroTrackBar3.Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtX1.Visible = false;
            txtY1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdaCuadrado.Checked == true)
            {
                x = float.Parse(txtX.Text) / 10;
                y = float.Parse(txtY.Text) / 10;
                ID_EVENT = 4;
            }
            if (rdaPunto.Checked == true)
            {
                x = float.Parse(txtX.Text) / 10;
                y = float.Parse(txtY.Text) / 10;
                ID_EVENT = 1;
            }
            if (rdaLinea.Checked == true)
            {
                x = float.Parse(txtX.Text) / 10;
                y = float.Parse(txtY.Text) / 10;
                y1 = float.Parse(txtY1.Text) / 10;
                x1 = float.Parse(txtX1.Text) / 10;

                if (x.ToString().Length>0 && y.ToString().Length>0 && x1.ToString().Length>0 && y1.ToString().Length>0)
                {
                    ID_EVENT = 2;
                }
                
            }


            if (rdaTriangulo.Checked == true )
            {
                x = float.Parse(txtX.Text) / 10;
                y = float.Parse(txtY.Text) / 10;
                ID_EVENT = 3;
            }

            if(rdaRec.Checked == true)
            {
                x = float.Parse(txtX.Text) / 10;
                y = float.Parse(txtY.Text) / 10;
                t = float.Parse(txtX1.Text) / 10;
                ID_EVENT = 5;
            }
                
            if(rdaCirculo.Checked == true)
            {
                x = float.Parse(txtX.Text) / 10;
                y = float.Parse(txtY.Text) / 10;
                t = float.Parse(txtX1.Text) / 10;
                ID_EVENT = 6;
            }
        }


        private void txtAxisX_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtX_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                                                                            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtY_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                                                                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdaPunto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdaLinea_CheckedChanged(object sender, EventArgs e)
        {
            if (rdaLinea.Checked)
            {
                txtY1.Visible = true;
                txtX1.Visible = true;
            }
            else
            {
                txtX1.Visible = false;
                txtY1.Visible = false;
            }
        }

        private void rdaCuadrado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdaRec_CheckedChanged(object sender, EventArgs e)
        {
            if (rdaRec.Checked)
            {
                txtX1.Visible = true;
                txtY1.Visible = false;
                lblX.Text = "Tamaño";
            }
            else
            {
                txtX1.Visible = false;
                txtY1.Visible = false;
                lblX.Text = "X1";
            }
        }

        private void rdaCirculo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdaCirculo.Checked)
            {
                txtX1.Visible = true;
                txtY1.Visible = false;
                lblX.Text = "Radio";
            }
            else
            {
                txtX1.Visible = false;
                txtY1.Visible = false;
                lblX.Text = "X1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ID_EVENT = 100;
        }
    }
}
