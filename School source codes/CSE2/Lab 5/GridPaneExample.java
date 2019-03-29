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

public class GridPaneExample extends Application {
   @Override
   public void start (Stage stage){
      Button button1 = new Button("YEETEN");
      Button button2 = new Button("YEETETH");
      Button button3 = new Button("YEET");
      Button button4 = new Button("YOTE");
      Button button5 = new Button("YATE");
      Button button6 = new Button("YOTEN");
      Text text1 = new Text("Test");
      GridPane gridPane = new GridPane();
      gridPane.setMinSize(400, 200);
      gridPane.setPadding(new Insets(10,10,10,10));
      gridPane.setVgap(5);
      gridPane.setHgap(5);
      gridPane.setAlignment(Pos.CENTER);
      gridPane.add(button3, 0, 0);
      gridPane.add(button4, 1, 0);
      gridPane.add(button5, 0, 1);
      gridPane.add(button6, 1, 1);
      gridPane.add(button1, 0, 2);
      gridPane.add(button2, 1, 2);
      gridPane.add(text1,2,3);
      Scene scene = new Scene(gridPane);
      stage.setTitle("LOL YOLO AMIRITE");
      stage.setScene(scene);
      stage.show();
      EventHandler<MouseEvent> button1Event = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) { 
            System.out.println("Hello World");
            text1.setText("Pressed Button 1");
         } 
      };
      EventHandler<MouseEvent> button2Event = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) { 
            System.out.println("Hello World");
            text1.setText("Pressed Button 2");
         } 
      };
      EventHandler<MouseEvent> button3Event = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) { 
            System.out.println("Hello World");
            text1.setText("Pressed Button 3");
         } 
      };
      EventHandler<MouseEvent> button4Event = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) { 
            System.out.println("Hello World");
            text1.setText("Pressed Button 4");
         } 
      };
      EventHandler<MouseEvent> button5Event = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) { 
            System.out.println("Hello World");
            text1.setText("Pressed Button 5");
         } 
      };
      EventHandler<MouseEvent> button6Event = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) { 
            System.out.println("Hello World");
            text1.setText("Pressed Button 6");
         } 
      };
      button1.addEventFilter(MouseEvent.MOUSE_CLICKED, button5Event);
      button2.addEventFilter(MouseEvent.MOUSE_CLICKED, button6Event);
      button3.addEventFilter(MouseEvent.MOUSE_CLICKED, button1Event);
      button4.addEventFilter(MouseEvent.MOUSE_CLICKED, button2Event);
      button5.addEventFilter(MouseEvent.MOUSE_CLICKED, button3Event);
      button6.addEventFilter(MouseEvent.MOUSE_CLICKED, button4Event);
   }
   public static void main(String[] args) {
      launch(args);
   }

}