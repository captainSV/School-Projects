import java.util.Random;

class MultiThreading extends Thread {
  public void run(int[] a, int start) { 
    try{ 
      //System.out.println("Thread " + Thread.currentThread().getId() + " is running");
      Main.bubbleSort(a, start);
    }catch (Exception e) { 
      System.out.println ("Exception is caught"); 
    } 
  } 
}

class Main {
  public static void main(String[] args) {
    Random rand = new Random();
    int[] testing = new int[10000];
    int[] testing2 = new int[10000];
    for(int i = 0; i < 10000; i++){
      testing[i] = rand.nextInt(100);
      testing2[i] = testing[i];
    }
    bubbleSort(testing, 0);
    System.out.println("Sorted Normally");
    for (int i=0; i < testing.length; ++i){
      System.out.print(testing[i] + " ");
    }
     System.out.println();
    MultiThreading a = new MultiThreading();
    MultiThreading s = new MultiThreading();
    MultiThreading z = new MultiThreading();
    a.run(testing2, 0);
    s.run(testing2, 33333);
    z.run(testing2, 66667);
    System.out.println("Sorted With Threads");
    for (int i=0; i < testing.length; ++i){
      System.out.print(testing2[i] + " ");
    }
  }

  static void bubbleSort(int arr[], int start) { 
    int n = arr.length; 
    for (int i = start; i < n-1; i++){
      for (int j = start; j < n-i-1; j++) {
        if (arr[j] > arr[j+1]) { 
          int temp = arr[j]; 
          arr[j] = arr[j+1]; 
          arr[j+1] = temp; 
        }
      }
    }
  }
}