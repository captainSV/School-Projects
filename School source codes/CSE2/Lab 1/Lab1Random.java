
//Sasha Angermueller
//CSE1322 Lab Section 06
import java.util.Random;
import java.util.Arrays;

class Lab1Random {
  public static void main(String[] args) {
    int[] nums = new int[]{1,4,13,43,-25,17,22,-37,29};
    int[] data1 = new int[20];
    int[] data2 = new int[20];
    data2 = fillArray(data1);
    int arraymax = findLargest(nums);
    int randmax = findLargest(data2);
    System.out.println("This is the static array's max: " + arraymax);
    System.out.println("This is the random array's max: " + randmax);
    System.out.println("This is them added together: " + (randmax+arraymax));
    System.out.println(Arrays.toString(data2));
    System.out.println(findLongest(data2));
  }
  private static int findLargest(int[] num) {
    int max = num[0];
    for (int count = 1; count < num.length; count++){
      if (num[count] > max) {
        max = num[count];
      }
    }
    return max;
  }
  private static int[] fillArray(int[] num) {
    Random rand = new Random();
    for (int counter = 0; counter < 20; counter++){
      num[counter] = rand.nextInt(100 + 1 + 100) - 100;
    }
    return num;
  }
  private static int findLongest(int[] num) {
    int max = 0;
    int length = 0;
    for (int countr = 0; countr < num.length; countr++){
      if (num[countr] > 0) {
        max++;
        if (max > length){
          length = max;
        }
      }else{
        max = 0;
      }
    }
    return length;
  }
}