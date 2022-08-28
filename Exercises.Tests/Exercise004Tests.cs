using NUnit.Framework;
using FluentAssertions;
using System;
using System.Globalization;

namespace Exercises.Tests
{
    public class Exercise004Tests
    {
        [Test]
        public void AddGigaSecond_Should_Return_Result_When_Only_Date_Is_Specified()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2021, 7, 19));
            DateTime expectedResult = new(2053, 3, 27, 1, 46, 40);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Return_Result_When_DateTime_Is_Specified()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2021, 3, 4, 23, 22, 0, 0));
            DateTime expectedResult = new(2052, 11, 11, 1, 8, 40);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Return_Result_When_DateTime_Is_Specified_With_Day_RollOver()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2021, 1, 24, 23, 59, 59, 0));
            DateTime expectedResult = new(2052, 10, 3, 1, 46, 39);
            actualResult.Should().Be(expectedResult);
        }

        //Additional Tests
        [Test]
        public void AddGigaSecond_Should_Return_Result_When_No_Specific_Date_Is_Passed()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime());
            DateTime expectedResult = new(0032, 09, 09, 01, 46, 40);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Return_Result_When_Date_Time_Kind_UTC_Is_Specified()
        {
            DateTimeKind dateTimeKind = DateTimeKind.Utc;
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2022, 8, 26, 0,0,0, dateTimeKind));
            DateTime expectedResult = new(2054, 5, 4, 01, 46, 40);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Return_Result_When_Thai_Buddhist_Calendar_Is_Specified()
        {
            // Create a CultureInfo for Thai in Thailand.
            CultureInfo thaiCalendar = CultureInfo.CreateSpecificCulture("th-TH");
            
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2022, 8, 26, 0, 0, 0, thaiCalendar.Calendar));
            DateTime expectedResult = new(1511, 5, 5, 1, 46, 40);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Return_Result_When_Japanese_Calendar_Is_Specified()
        {
            // Create a CultureInfo for Japanese in Japan.
            CultureInfo japanCalendar = CultureInfo.CreateSpecificCulture("ja-JP");

            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2022, 8, 26, 0, 0, 0, japanCalendar.Calendar));
            DateTime expectedResult = new(2054, 5, 4, 01, 46, 40);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Return_Result_When_Hijri_Calendar_Is_Specified()
        {
            // Create a CultureInfo for Arabic in Saudi Arabia - Hijri Calendar.
            CultureInfo hijriCalendar = CultureInfo.CreateSpecificCulture("ar-SA");

            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(1415, 8, 26, 0, 0, 0, hijriCalendar.Calendar));
            DateTime expectedResult = new(2026, 10, 5, 01, 46, 40);
            actualResult.Should().Be(expectedResult);
        }

            
    }
}
