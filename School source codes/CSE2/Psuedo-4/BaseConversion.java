public class BaseConversion{
  public static void main ( String args[] ){
    System.out.println(convert(1023,32));
  }
  public static String convert(int number, int base){
    return converter(number, base, 0, "" );
  }

  public static String converter ( int number, int base, int position, String result ){
    char[] numbers = new char[] {'0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V'};
    if ( number < Math.pow(base, position + 1) ){
      //System.out.println("Thrown: number < math.pow(base,pos+1)");
      return numbers[(number / (int)Math.pow(base, position))] + result;
    }else{
      //System.out.println("Thrown: number !< math.pow(base,pos+1)");
      //System.out.println(number);
      int remainder = (number % (int)Math.pow(base, position + 1));
      //System.out.println("Thrown remainder: " + ((number % (int)Math.pow(base, position + 1))));
      //System.out.println("Thrown recursion: " + (numbers[remainder / (int)( Math.pow(base, position) )] + result));
      return converter(number - remainder, base, position + 1, numbers[remainder / (int)( Math.pow(base, position) )] + result );
    }
  }
}