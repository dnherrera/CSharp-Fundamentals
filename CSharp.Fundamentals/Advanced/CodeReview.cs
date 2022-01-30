using System;

namespace CSharp.Fundamentals.Advanced
{
	class Rate
	{
		protected double _rate;

        public Rate(double rate)
		{
			if (rate < 0.0 || rate > 1.0)
			{
				throw new IndexOutOfRangeException("Rate ranging error");
			}
			_rate = rate;
		}
	
		double GetRate()
		{
			return _rate;
		}

		double ComputeDailyCompoundedInterest(double principal, Rate daily_rate, double days)
		{
			double i = principal * daily_rate.GetRate() * days;    // compute daily interest
			return i;
		}

		double ComputeMonthlyCompoundedInterest(double principal, Rate monthly_rate, double months)
		{
			double i = principal * monthly_rate.GetRate() * months;  // compute monthly interest
			return i;
		}

		double ComputeAnnualCompoundedInterest(double principal, Rate yearly_rate, double years)
		{
			double i = principal * yearly_rate.GetRate() * years;  // compute monthly interest
			return i;
		}
	}
}
