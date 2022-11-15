//Write a public method that accepts a number
// 1.access modifier
//2. return type
//3. Method Name
//4.Parameters
//5. Scope

//when the number is divisible by 3 return the word fizz

//when the number is divisible by 5 return the word buzz

//when the number is divisible by both, return the word fizzbuzz

 string FizzBuzz(int number)
{

    var answer = "";

    //when the number is divisible by 3 return the word fizz
    if(number % 3 == 0)
    {
        answer = "fizz";
    }
    if (number % 5 == 0)
    {
        answer += "buzz"; //answer = answer + "buzz"
    }
    return answer;
    //when the number is divisible by 5 return the word buzz

    //when the number is divisible by both, return the word fizzbuzz

}