/*namespace CSharp.Fundamentals.Advanced
{

    class Rate
	{
		protected: // Please remove this colon(:) then put the next line here because this invalid decalaration.
    double my_rate; // Please rename this variable name to "_rate" to make it like as injector and to remove as well the ambiguity between this variable and the variable 'rate' in the constructor. 
		public: // Please remove this colon(:) then put the next line here to make the constructor works.
	Rate(double rate) // Please put this line up there after 'Public' access modifier.
		{
			if (rate < 0.0 || rate > 1.0)
			{
				throw std::range_error("Rate ranging error"); // I believe this is not the correct way to throw an exception like this in C#, thus could you please change 'std::range_error' to 'new IndexOutOfRangeException'.
			}
			my_rate = rate; // Please change this 'my_rate' to _rate as I mentioned above.
		}
	
	operator double () { // Sorry, but I think this is not correct way to create a method, so please remove the operator keyword and put method name before datatype double e.g. GetRate(). 
		return my_rate; // 'my_rate' to _rate as I mentioned above.
	}
	}; // Please remove this semi-colon here. It's not necessary.

// Please move this method inside the Rate Class.
double ComputeDailyCompoundedInterest(double principle, Rate daily_rate, double days) // There's typo variable here, please change 'principle' to 'principal'.
{
	// 1. Please change the 'principle' to 'principal' as we changed it earlier.
	// 2. Use the new method we've created earlier i.e GetRate(), thus please change 'daily_rate' below to 'daily_rate.GetRate()'
	double i = principle * daily_rate * days;    // compute daily interest 
	return i;
}

// Please move this method inside the Rate Class.
double ComputeMonthlyCompoundedInterest(double principal, Rate montly_rate, double months) // There's typo variable here, please change 'montly_rate' to 'monthly_rate'
{
	// 1. Please change principle to 'principal' as there's no principle variable name in the signature.
	// 2. Use the new method we've created earlier i.e GetRate(), thus please change 'monthly_rate' below to 'monthly_rate.GetRate()'
	double i = principle * monthly_rate * months;  // compute monthly interest
	return i;
}

// Please move this method inside the Rate Class.
double ComputeAnnuleCompoundedInterest(double principal, Rate yearly_rate, double years) // Please change word  'Annule' to 'Annual' since it's typo.
{
	// 1. Use the new method we've created earlier i.e GetRate(), thus please change 'yearly_rate' below to 'yearly_rate.GetRate()'
	double i = principal * yearly_rate * years;  // compute monthly interest
	return i;
}
}
*/