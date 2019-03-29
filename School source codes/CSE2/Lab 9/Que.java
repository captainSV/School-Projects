class Que{
  int start, end, count, size;
  Food[] yeet;

  public Que(){
    start = 0;
    end = 0;
    count = 0;
    size = 20;
    yeet = new Food[size];
  }

  public void enque(Food a){
    yeet[end] = a;

    end = (end+1)%size;
    count++;
  }

  public Food deque(){
    Food a = yeet[start];
    yeet[start] = new Food(null,0,0);
    start = (start+1)%size;
    count--;

    return a;
  }

  public Food peek(){
    return yeet[start];
  }

  public int avgCal(){
    int avg = 0;
    for(int i = 0; i < end; i++){
      if(yeet[i].name == null){}else{
        avg += yeet[i].serCal;
      }
    }
    return avg/count;
  }

  public String highestCal(){
    int highest = 0;
    String hgName = "";
    for(int i = 0; i < end; i++){
      if(yeet[i] != null || yeet[i].name != null){
        if(yeet[i].serCal*yeet[i].serPer > highest){
          highest = yeet[i].serCal*yeet[i].serPer;
          hgName = yeet[i].name;
        }
      }
    }
    return hgName + ": " + highest + " Calories.";
  }
}