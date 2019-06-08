import javafx.application.Application;
import javafx.geometry.Pos;
import javafx.geometry.Insets;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.layout.GridPane;
import javafx.scene.text.Text;
import javafx.scene.control.TextField;
import javafx.stage.Stage;
import javafx.event.EventHandler;
import javafx.scene.input.MouseEvent;
import java.io.*;
import java.util.Scanner;
import javafx.scene.control.TextArea;

public class Editor extends Application {
   public double eqPartOne = 0;
   public double eqPartTwo = 0;
   @Override
   public void start (Stage stage){
      Label answer = new Label("Calculator");
      Button buttonEq = new Button("Get");
      Button buttonSV = new Button("Save");
      TextField text1 = new TextField();
      TextArea text2 = new TextArea();
      GridPane gridPane = new GridPane();
      gridPane.setMinSize(400, 200);
      gridPane.setPadding(new Insets(10,10,10,10));
      gridPane.setVgap(5);
      gridPane.setHgap(5);
      gridPane.setAlignment(Pos.CENTER);
      gridPane.add(text1, 0, 1);
      gridPane.add(text2, 0, 2);
      gridPane.add(buttonEq, 1, 1);
      gridPane.add(buttonSV, 1, 2);
      gridPane.add(answer, 3, 1);
      Scene scene = new Scene(gridPane);
      stage.setTitle("LOL YOLO AMIRITE, but a Calculator this time");
      stage.setScene(scene);
      stage.show();
      EventHandler<MouseEvent> buttonEqEvent = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) {
           String yeet = "";
           try{
            Scanner scan = new Scanner(new File(text1.getCharacters().toString()));
            while(scan.hasNextLine()) {
               yeet += scan.nextLine();
            }
           }catch(Exception t){
            text2.setText("That's not a findable file)");
           }
           text2.setText(yeet);
         }
      };
      EventHandler<MouseEvent> buttonSVEvent = new EventHandler<MouseEvent>() { 
         @Override 
         public void handle(MouseEvent e) {
           String yeet = text2.getText();
           try (PrintStream out = new PrintStream(new FileOutputStream(text1.getCharacters().toString()))){
            out.print(yeet);
           }catch(Exception m){
            System.out.println("Something went wrong");
           }
         }
      };
      buttonEq.addEventFilter(MouseEvent.MOUSE_CLICKED, buttonEqEvent);
      buttonSV.addEventFilter(MouseEvent.MOUSE_CLICKED, buttonSVEvent);
   }
   public static void main(String[] args) {
      launch(args);
   }
}