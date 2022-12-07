using Google.OrTools.LinearSolver;

namespace LR3_Modelirovanie.Models;

    public class ResultViewModel
    {
        public DataViewModel dataViewModel;

        public ResultViewModel(DataViewModel dataViewModel)
        {
            this.dataViewModel = dataViewModel;
            SolverRun();
        }


        public void SolverRun()
        {
            Solver solver = Solver.CreateSolver("GLOP");

            Variable x1 = solver.MakeNumVar(0.0, double.PositiveInfinity, "x1");
            Variable x2 = solver.MakeNumVar(0.0, double.PositiveInfinity, "x2");
            Variable x3 = solver.MakeNumVar(0.0, double.PositiveInfinity, "x3");
            Variable x4 = solver.MakeNumVar(0.0, double.PositiveInfinity, "x4");
            Variable x5 = solver.MakeNumVar(0.0, double.PositiveInfinity, "x5");

        solver.Add(
            (x1 * dataViewModel.A1_1 + x2 * dataViewModel.A1_2 +
            x3 * dataViewModel.A1_3 + x4 * dataViewModel.A1_4 +
            x5 * dataViewModel.A1_5) ==
            (dataViewModel.R * dataViewModel.A1_AmountOn1)
            );

        solver.Add(
            (x1 * dataViewModel.A2_1 + x2 * dataViewModel.A2_2 +
            x3 * dataViewModel.A2_3 + x4 * dataViewModel.A2_4 +
            x5 * dataViewModel.A2_5) ==
            (dataViewModel.R * dataViewModel.A2_AmountOn1)
            );

        solver.Add(
            (x1 * dataViewModel.A3_1 + x2 * dataViewModel.A3_2 +
            x3 * dataViewModel.A3_3 + x4 * dataViewModel.A3_4 +
            x5 * dataViewModel.A3_5) ==
            (dataViewModel.R * dataViewModel.A3_AmountOn1)
            );


        solver.Minimize(Waste1 * x1 + Waste2 * x2 + Waste3 * x3 + Waste4 * x4 + Waste5 * x5);

            Solver.ResultStatus resultStatus = solver.Solve();

            Cel = Math.Round(solver.Objective().Value(), 0);

            X1 = Math.Round(x1.SolutionValue(), 0);
            X2 = Math.Round(x2.SolutionValue(), 0);
            X3 = Math.Round(x3.SolutionValue(), 0);
            X4 = Math.Round(x4.SolutionValue(), 0);
            X5 = Math.Round(x5.SolutionValue(), 0);
      
    }



        public double X1 { get; set; }
        public double X2 { get; set; }
        public double X3 { get; set; }
        public double X4 { get; set; }
        public double X5 { get; set; }

        
        public double Waste1
        {
        get => dataViewModel.F - (
            dataViewModel.A1_Square * dataViewModel.A1_1 +
            dataViewModel.A2_Square * dataViewModel.A2_1 +
            dataViewModel.A3_Square * dataViewModel.A3_1);                
        }
        public double Waste2
    {
            get => dataViewModel.F - (
                dataViewModel.A1_Square * dataViewModel.A1_2 +
                dataViewModel.A2_Square * dataViewModel.A2_2 +
                dataViewModel.A3_Square * dataViewModel.A3_2);
        }
        public double Waste3
        {
            get => dataViewModel.F - (
                dataViewModel.A1_Square * dataViewModel.A1_3 +
                dataViewModel.A2_Square * dataViewModel.A2_3 +
                dataViewModel.A3_Square * dataViewModel.A3_3);
        }
        public double Waste4
        {
            get => dataViewModel.F - (
                dataViewModel.A1_Square * dataViewModel.A1_4 +
                dataViewModel.A2_Square * dataViewModel.A2_4 +
                dataViewModel.A3_Square * dataViewModel.A3_4);
        }
        public double Waste5
        {
            get => dataViewModel.F - (
                dataViewModel.A1_Square * dataViewModel.A1_5 +
                dataViewModel.A2_Square * dataViewModel.A2_5 +
                dataViewModel.A3_Square * dataViewModel.A3_5);
        }

        public double Cel { get; set; }

      
    }
