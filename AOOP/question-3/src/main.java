

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;


public class main {
    public static void main(String args[])
    {
        ABC obj = new ABC();
    }
}

class ABC extends JFrame implements ActionListener
{
    JLabel l1;
    JRadioButton r1, r2,r3;  
    JButton b1;

    
    public ABC()
    {
        
        setVisible(true);
        setSize(400, 400);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new FlowLayout());


        r1 = new JRadioButton("Red");
        r2 = new JRadioButton("Yellow");
        r3 = new JRadioButton("Green");
        
        b1 = new JButton("Submit");
        
        l1 = new JLabel();

        
        
        ButtonGroup bg = new ButtonGroup();
        bg.add(r1);
        bg.add(r2);
        bg.add(r3);
        
        
        
        add(r1);add(r2);add(r3);add(b1);add(l1);
       
        b1.addActionListener(this);
        
        
        
        
    }
    
     public void actionPerformed(ActionEvent ae)
     {
        
        String message = null;
        
        if(r1.isSelected())
        {
             message = "Stop";
        }
        else if(r2.isSelected())
        {
             message = "Ready";
        }
        else if(r3.isSelected())
        {
             message = "Go";
        }
      
        l1.setText(message);

        
     }
}