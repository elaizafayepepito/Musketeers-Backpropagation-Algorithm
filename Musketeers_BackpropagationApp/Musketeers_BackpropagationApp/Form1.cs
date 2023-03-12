using Backprop;

namespace Musketeers_BackpropagationApp
{
    public partial class Form1 : Form
    {
        NeuralNet neuralNet;
        public Form1()
        {
            InitializeComponent();
        }

        private void create_Click(object sender, EventArgs e)
        {
            neuralNet = new NeuralNet(4, 20, 1);
        }

        private void train_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < Convert.ToInt32(epoch.Text); x++)
            {
                //Iris-setosa
                neuralNet.setInputs(0, 5.1);
                neuralNet.setInputs(1, 3.5);
                neuralNet.setInputs(2, 1.4);
                neuralNet.setInputs(3, 0.2);
                neuralNet.setDesiredOutput(0, 0);
                neuralNet.learn();

                neuralNet.setInputs(0, 4.9);
                neuralNet.setInputs(1, 3);
                neuralNet.setInputs(2, 1.4);
                neuralNet.setInputs(3, 0.2);
                neuralNet.setDesiredOutput(0, 0);
                neuralNet.learn();

                neuralNet.setInputs(0, 4.7);
                neuralNet.setInputs(1, 3.2);
                neuralNet.setInputs(2, 1.3);
                neuralNet.setInputs(3, 0.2);
                neuralNet.setDesiredOutput(0, 0);
                neuralNet.learn();

                neuralNet.setInputs(0, 4.6);
                neuralNet.setInputs(1, 3.1);
                neuralNet.setInputs(2, 1.5);
                neuralNet.setInputs(3, 0.2);
                neuralNet.setDesiredOutput(0, 0);
                neuralNet.learn();

                neuralNet.setInputs(0, 5);
                neuralNet.setInputs(1, 3.9);
                neuralNet.setInputs(2, 1.7);
                neuralNet.setInputs(3, 0.2);
                neuralNet.setDesiredOutput(0, 0);
                neuralNet.learn();

                neuralNet.setInputs(0, 5.4);
                neuralNet.setInputs(1, 3.9);
                neuralNet.setInputs(2, 1.7);
                neuralNet.setInputs(3, 0.4);
                neuralNet.setDesiredOutput(0, 0);
                neuralNet.learn();

                neuralNet.setInputs(0, 4.6);
                neuralNet.setInputs(1, 3.4);
                neuralNet.setInputs(2, 1.4);
                neuralNet.setInputs(3, 0.3);
                neuralNet.setDesiredOutput(0, 0);
                neuralNet.learn();

                neuralNet.setInputs(0, 5);
                neuralNet.setInputs(1, 3.4);
                neuralNet.setInputs(2, 1.5);
                neuralNet.setInputs(3, 0.2);
                neuralNet.setDesiredOutput(0, 0);
                neuralNet.learn();

                neuralNet.setInputs(0, 4.4);
                neuralNet.setInputs(1, 2.9);
                neuralNet.setInputs(2, 1.4);
                neuralNet.setInputs(3, 0.2);
                neuralNet.setDesiredOutput(0, 0);
                neuralNet.learn();

                neuralNet.setInputs(0, 4.9);
                neuralNet.setInputs(1, 3.1);
                neuralNet.setInputs(2, 1.5);
                neuralNet.setInputs(3, 0.2);
                neuralNet.setDesiredOutput(0, 0);
                neuralNet.learn();

                //Iris-versicolor
                neuralNet.setInputs(0, 7);
                neuralNet.setInputs(1, 3.2);
                neuralNet.setInputs(2, 4.7);
                neuralNet.setInputs(3, 1.4);
                neuralNet.setDesiredOutput(0, 0.5);
                neuralNet.learn();

                neuralNet.setInputs(0, 6.4);
                neuralNet.setInputs(1, 3.2);
                neuralNet.setInputs(2, 4.5);
                neuralNet.setInputs(3, 1.5);
                neuralNet.setDesiredOutput(0, 0.5);
                neuralNet.learn();

                neuralNet.setInputs(0, 6.9);
                neuralNet.setInputs(1, 3.1);
                neuralNet.setInputs(2, 4.9);
                neuralNet.setInputs(3, 1.5);
                neuralNet.setDesiredOutput(0, 0.5);
                neuralNet.learn();

                neuralNet.setInputs(0, 5.5);
                neuralNet.setInputs(1, 2.3);
                neuralNet.setInputs(2, 4);
                neuralNet.setInputs(3, 1.3);
                neuralNet.setDesiredOutput(0, 0.5);
                neuralNet.learn();

                neuralNet.setInputs(0, 6.5);
                neuralNet.setInputs(1, 2.8);
                neuralNet.setInputs(2, 4.6);
                neuralNet.setInputs(3, 1.5);
                neuralNet.setDesiredOutput(0, 0.5);
                neuralNet.learn();

                neuralNet.setInputs(0, 5.7);
                neuralNet.setInputs(1, 2.8);
                neuralNet.setInputs(2, 4.5);
                neuralNet.setInputs(3, 1.5);
                neuralNet.setDesiredOutput(0, 0.5);
                neuralNet.learn();

                neuralNet.setInputs(0, 6.3);
                neuralNet.setInputs(1, 3.3);
                neuralNet.setInputs(2, 4.7);
                neuralNet.setInputs(3, 1.6);
                neuralNet.setDesiredOutput(0, 0.5);
                neuralNet.learn();

                neuralNet.setInputs(0, 4.9);
                neuralNet.setInputs(1, 2.4);
                neuralNet.setInputs(2, 3.3);
                neuralNet.setInputs(3, 1);
                neuralNet.setDesiredOutput(0, 0.5);
                neuralNet.learn();

                neuralNet.setInputs(0, 6.6);
                neuralNet.setInputs(1, 2.9);
                neuralNet.setInputs(2, 4.6);
                neuralNet.setInputs(3, 1.3);
                neuralNet.setDesiredOutput(0, 0.5);
                neuralNet.learn();

                neuralNet.setInputs(0, 5.2);
                neuralNet.setInputs(1, 2.7);
                neuralNet.setInputs(2, 3.9);
                neuralNet.setInputs(3, 1.4);
                neuralNet.setDesiredOutput(0, 0.5);
                neuralNet.learn();

                //Iris--virginica
                neuralNet.setInputs(0, 6.3);
                neuralNet.setInputs(1, 3.3);
                neuralNet.setInputs(2, 6);
                neuralNet.setInputs(3, 2.5);
                neuralNet.setDesiredOutput(0, 1);
                neuralNet.learn();

                neuralNet.setInputs(0, 5.8);
                neuralNet.setInputs(1, 2.7);
                neuralNet.setInputs(2, 5.1);
                neuralNet.setInputs(3, 1.9);
                neuralNet.setDesiredOutput(0, 1);
                neuralNet.learn();

                neuralNet.setInputs(0, 7.1);
                neuralNet.setInputs(1, 3);
                neuralNet.setInputs(2, 5.9);
                neuralNet.setInputs(3, 2.1);
                neuralNet.setDesiredOutput(0, 1);
                neuralNet.learn();

                neuralNet.setInputs(0, 6.3);
                neuralNet.setInputs(1, 2.9);
                neuralNet.setInputs(2, 5.6);
                neuralNet.setInputs(3, 1.8);
                neuralNet.setDesiredOutput(0, 1);
                neuralNet.learn();

                neuralNet.setInputs(0, 6.5);
                neuralNet.setInputs(1, 3);
                neuralNet.setInputs(2, 5.8);
                neuralNet.setInputs(3, 2.2);
                neuralNet.setDesiredOutput(0, 1);
                neuralNet.learn();

                neuralNet.setInputs(0, 7.6);
                neuralNet.setInputs(1, 3);
                neuralNet.setInputs(2, 6.6);
                neuralNet.setInputs(3, 2.1);
                neuralNet.setDesiredOutput(0, 1);
                neuralNet.learn();

                neuralNet.setInputs(0, 4.9);
                neuralNet.setInputs(1, 2.5);
                neuralNet.setInputs(2, 4.5);
                neuralNet.setInputs(3, 1.7);
                neuralNet.setDesiredOutput(0, 1);
                neuralNet.learn();

                neuralNet.setInputs(0, 7.3);
                neuralNet.setInputs(1, 2.9);
                neuralNet.setInputs(2, 6.3);
                neuralNet.setInputs(3, 1.8);
                neuralNet.setDesiredOutput(0, 1);
                neuralNet.learn();

                neuralNet.setInputs(0, 6.7);
                neuralNet.setInputs(1, 2.5);
                neuralNet.setInputs(2, 5.8);
                neuralNet.setInputs(3, 1.8);
                neuralNet.setDesiredOutput(0, 1);
                neuralNet.learn();

                neuralNet.setInputs(0, 7.2);
                neuralNet.setInputs(1, 3.6);
                neuralNet.setInputs(2, 6.1);
                neuralNet.setInputs(3, 2.5);
                neuralNet.setDesiredOutput(0, 1);
                neuralNet.learn();
            }
        }

        private void test_Click(object sender, EventArgs e)
        {
            neuralNet.setInputs(0, Convert.ToDouble(textBox1.Text));
            neuralNet.setInputs(1, Convert.ToDouble(textBox2.Text));
            neuralNet.setInputs(2, Convert.ToDouble(textBox3.Text));
            neuralNet.setInputs(3, Convert.ToDouble(textBox4.Text));
            neuralNet.run();

            double value = neuralNet.getOuputData(0);

            output.Text = "" + value;

            if (Math.Abs(value - 0) < Math.Abs(value - 0.5) && Math.Abs(value - 0) < Math.Abs(value - 1))
            {
                name.Text = "Iris-Setosa";
            }
            else if (Math.Abs(value - 0.5) < Math.Abs(value - 0) && Math.Abs(value - 0.5) < Math.Abs(value - 1))
            {
                name.Text = "Iris-Versicolor";
            }
            else
            {
                name.Text = "Iris-Virginica";
            }
        }
    }
}