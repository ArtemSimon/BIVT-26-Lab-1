namespace Lab1
{
    public class Blue
    {
        public bool Task1(int a, int b)
        {
            bool answer = false;

            // code here
            answer = ((a > 0) && (b> 0)) || ((a < 0) && (b < 0)) || (a == 0) && (b == 0);
            System.Console.WriteLine(answer);
            // end

            return answer;
        }
        public bool Task2(double d)
        {
            bool answer = false;

            // code here
            double drob = d % 1;
                
            if (drob < 0)    
                drob = -drob;
        
            if (drob > 0.0001 ) 
                answer = true;
            // end

            return answer ;
        }
        public bool Task3(int a, int b)
        {
            bool answer = false;

            // code here
            answer = a % b == 0;
            // end

            return answer;
        }
        public double Task4(double d, double f, double g)
        {
            double answer = 0;
            // int newd = int(d);
            double[] arr = {Math.Abs(d), Math.Abs(f), Math.Abs(g)};
            // code here
            answer = arr.Max();
            
            // end

            return answer;
        }
        public double Task5(double x)
        {
            double answer = 0;

            // code here
            if (x <= -1) {
                answer = 0;
            }
            if (-1 < x && x <= 0) {
                answer = x+1;
            }
            else
            {
                answer = 1;
            }
            // end

            return answer;
        }
        public bool Task6(double circleS, double squareS)
        {
            bool answer = false;

            // code here
            double side = Math.Sqrt(squareS);
            double radius = Math.Sqrt(circleS / Math.PI);

            double diam = 2 * radius;

            if (diam <= side ) {
                answer = true;
            }
            // end

            return answer;
        }

        public double Task7(double d, double f)
        {
            int answer = 0;

            // code here
            if (Math.Abs(d) < Math.Abs(f)) {
                if (d > 0)
                {
                    answer -= 1;
                }
                else
                {
                    answer += 0;
                }
            }
            else
            {
                if (f > 0)
                {
                    answer = 1;
                }
                else
                {
                    answer += 0;
                }
            }
            // end

            return answer;
        }
        public bool Task8(int a, int b, int c)
        {
            bool answer = false;

            // code here
            int old = a / 2;
            int middle = b / 2; 
            int young = c / 2;

            int total = old + middle + young;

            int mxCapacity = Math.Min(a, Math.Min(b,c));

            if (total % 3 == 0 )
            {
                int target = total / 3 ;
                if (target >= 1 && target <= mxCapacity)
                {
                    answer = true;
                }

            }

            int targetBonusMoney = total + 1;
            if (targetBonusMoney % 3 == 0)
            {
                int target = targetBonusMoney / 3;
                if (target >= 1 && target <= mxCapacity)
                {
                    answer = true;
                }
            }

            // end

            return answer;
        }
    }
}