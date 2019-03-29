public class linklist{
	Node head; 

  class Node {
	  int data;
    int id;
	  Node next; 
	  public Node(int a, int b){
	  	data = a;
      id = b;
	  }
	  public String toString(){
		  return "" + data;
	  }
  }

	linklist(){
		head = null;
	}

	public boolean isEmpty(){
		return(head == null);
	}

	public void add(int a){
		if (head == null) {
			head = new Node(a, 0);
			return; 
		}
		Node currentNode = head;
    int temp = 1;
		while(currentNode.next != null) {
			currentNode = currentNode.next;
      temp++;
		}
		currentNode.next = new Node(a, temp);
	}

	public String list(){
		Node theNode = head;
    String yeet = "";
		while(theNode != null){
			yeet += (theNode + ", ");
			theNode = theNode.next;
		}
    return yeet.substring(0,yeet.length()-2);
	}

  public int size(){
		Node theNode = head;
    int yeet = 0;
		while(theNode != null){
			yeet += 1;
			theNode = theNode.next;
		}
    return yeet;
	}

  public int get(int id){
		Node theNode = head;
		if(!isEmpty()){
			while(theNode.id != id){
				if(theNode.next == null){
					return -1;
				} else {
					theNode = theNode.next;
				}
			}
		} else {
			System.out.println("Empty LinkedList");
		}
		return theNode.data;
	}
}