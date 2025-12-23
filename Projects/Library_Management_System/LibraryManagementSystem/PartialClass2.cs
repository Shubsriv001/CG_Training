using System;

namespace LibraryManagementSystem
{
partial class LibraryAnalytics
{
    public void display_analytics(int a)
    {
        int analytic_value=1+a;
        Console.WriteLine($"Total Borrowed Item {analytic_value}");
    }
}}