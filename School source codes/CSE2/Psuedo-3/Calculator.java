import javafx.application.Application;
import javafx.geometry.Pos;
import javafx.geometry.Insets;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.layout.GridPane;
import javafx.scene.text.Text;
import javafx.scene.control.TextField;
import javafx.stage.Stage;
import javafx.event.EventHandler;
import javafx.scene.input.MouseEvent;

public class Calculator extends Application {
   public String eqPartOne = "";
   public String eqPartTwo = "";
   public int oporand = 999;
   @Override
   public void start (Stage stage){
      Button button1 = new Button("1");
      Button button2 = new Button("2");
      Button button3 = new Button("3");
      Button button4 = new Button("4");
      Button button5 = new Button("5");
      Button button6 = new Button("6");
      Button button7 = new Button("7");
      Button button8 = new Button("8");
      Button button9 = new Button("9");
      Button button0 = new Button("0");
      Button buttonEq = new Button("=");
      Button buttonAdd = new Button("+");
      Button buttonSub = new Button("-");
      Button buttonMul = new Button("*");
      Button buttonDiv = new Button("/");
      Text text1 = new Text("");
      GridPane gridPane = new GridPane();
      gridPane.setMinSize(400, 200);
      gridPane.setPadding(new Insets(10,10,10,10));
      gridPane.setVgap(5);
      gridPane.setHgap(5);
      gridPane.setAlignment(Pos.CENTER);
      gridPane.add(text1, 0, 0);
      gridPane.add(button1, 1, 0);
      gridPane.add(button2, 1, 1);
      gridPane.add(button3, 1, 2);
      gridPane.add(button4, 2, 0);
      gridPane.add(button5, 2, 1);
      gridPane.add(button6, 2, 2);
      gridPane.add(button7, 3, 0);
      gridPane.add(button8, 3, 1);
      gridPane.add(button9, 3, 2);
      gridPane.add(button0, 4, 0);
      gridPane.add(buttonEq, 4, 2);
      gridPane.add(buttonAdd, 0, 3);
      gridPane.add(buttonSub, 1, 3);
      gridPane.add(buttonMul, 2, 3);
      gridPane.add(buttonDiv, 3, 3);
      Scene scene = new Scene(gridPane);
      stage.setTitle("LOL YOLO AMIRITE, but a Calculator this time");
      stage.setScene(scene);
      stage.show();
      EventHandler<MouseEvent> button1Event = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) { 
            text1.setText(text1 +"1");
         } 
      };
      EventHandler<MouseEvent> button2Event = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) { 
            text1.setText(text1 +"2");
         } 
      };
      EventHandler<MouseEvent> button3Event = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) { 
            text1.setText(text1 +"3");
         } 
      };
      EventHandler<MouseEvent> button4Event = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) { 
            text1.setText(text1 +"4");
         } 
      };
      EventHandler<MouseEvent> button5Event = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) { 
            text1.setText(text1 +"5");
         } 
      };
      EventHandler<MouseEvent> button6Event = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) { 
            text1.setText(text1 +"6");
         } 
      };
      EventHandler<MouseEvent> button6Event = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) { 
            text1.setText(text1 +"7");
         } 
      };
      EventHandler<MouseEvent> button6Event = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) { 
            text1.setText(text1 +"8");
         } 
      };
      EventHandler<MouseEvent> button6Event = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) { 
            text1.setText(text1 +"9");
         } 
      };
      EventHandler<MouseEvent> buttonEqEvent = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) {
           if (oporand == 999){
             text1.setText("Actually choose an oporand first, please");
           }else if (oporand == 0){
             text1.setText(Integer.parseInt(eqPartOne) + Integer.parseInt(eqPartTwo));
           }else if (oporand == 1){
             text1.setText(Integer.parseInt(eqPartOne) - Integer.parseInt(eqPartTwo));
           }else if (oporand == 2){
             text1.setText(Integer.parseInt(eqPartOne) * Integer.parseInt(eqPartTwo));
           }else{
             text1.setText(Integer.parseInt(eqPartOne) / Integer.parseInt(eqPartTwo));
           }
         } 
      };
      EventHandler<MouseEvent> buttonAddEvent = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) { 
            oporand = 0;
         } 
      };
      EventHandler<MouseEvent> buttonSubEvent = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) { 
            oporand = 1;
         } 
      };
      EventHandler<MouseEvent> buttonMulEvent = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) { 
            oporand = 2;
         } 
      };
      EventHandler<MouseEvent> buttonDivEvent = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) { 
            oporand = 3;
         } 
      };
      button1.addEventFilter(MouseEvent.MOUSE_CLICKED, button1Event);
      button2.addEventFilter(MouseEvent.MOUSE_CLICKED, button2Event);
      button3.addEventFilter(MouseEvent.MOUSE_CLICKED, button3Event);
      button4.addEventFilter(MouseEvent.MOUSE_CLICKED, button4Event);
      button5.addEventFilter(MouseEvent.MOUSE_CLICKED, button5Event);
      button6.addEventFilter(MouseEvent.MOUSE_CLICKED, button6Event);
      button7.addEventFilter(MouseEvent.MOUSE_CLICKED, button7Event);
      button8.addEventFilter(MouseEvent.MOUSE_CLICKED, button8Event);
      button9.addEventFilter(MouseEvent.MOUSE_CLICKED, button9Event);
      buttonEq.addEventFilter(MouseEvent.MOUSE_CLICKED, buttonEqEvent);
      buttonAdd.addEventFilter(MouseEvent.MOUSE_CLICKED, buttonAddEvent);
      buttonSub.addEventFilter(MouseEvent.MOUSE_CLICKED, buttonSubEvent);
      buttonMul.addEventFilter(MouseEvent.MOUSE_CLICKED, buttonMulEvent);
      buttonDiv.addEventFilter(MouseEvent.MOUSE_CLICKED, buttonDivEvent);
   }
   public static void main(String[] args) {
      launch(args);
   }

}