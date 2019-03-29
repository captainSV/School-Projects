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
   public double eqPartOne = "";
   public double eqPartTwo = "";
   @Override
   public void start (Stage stage){
      Label label1 = new Label("Calculator");
      Button buttonEq = new Button("=");
      Text answer = new Text("")
      TextFeild text1 = new TextField();
      TextFeild text2 = new TextField();
      GridPane gridPane = new GridPane();
      gridPane.setMinSize(400, 200);
      gridPane.setPadding(new Insets(10,10,10,10));
      gridPane.setVgap(5);
      gridPane.setHgap(5);
      gridPane.setAlignment(Pos.CENTER);
      gridPane.add(label1, 0, 0);
      gridPane.add(text1, 0, 1);
      gridPane.add(text2, 0, 2);
      gridPane.add(buttonEq, 1, 2);
      gridPane.add(answer, 3, 1);
      Scene scene = new Scene(gridPane);
      stage.setTitle("LOL YOLO AMIRITE, but a Calculator this time");
      stage.setScene(scene);
      stage.show();
      EventHandler<MouseEvent> buttonEqEvent = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) {
           eqPartOne = (double)text1.toString;
           eqPartTwo = (double)text2.toString;
           answer.setText("" + (eqPartOne + eqPartTwo));
         } 
      };
      buttonEq.addEventFilter(MouseEvent.MOUSE_CLICKED, buttonEqEvent);
   }
   public static void main(String[] args) {
      launch(args);
   }

}