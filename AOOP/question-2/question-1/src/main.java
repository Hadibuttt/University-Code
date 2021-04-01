
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class main {

    public static void main(String args[]) {
        ABC obj = new ABC();
    }
}

class ABC extends JFrame implements ActionListener {

    JButton b1, b2, b3, b4;
    JRadioButton r1, r2, r3;
    JCheckBox c1, c2, c3;

    public ABC() {

        setVisible(true);
        setSize(400, 400);
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        setLayout(new FlowLayout());

        b1 = new JButton("Green");
        b2 = new JButton("Blue");
        b3 = new JButton("Black");
        b4 = new JButton("Change color");
        

        r1 = new JRadioButton("Green");
        r2 = new JRadioButton("Blue");
        r3 = new JRadioButton("Black");

        c1 = new JCheckBox("Green");
        c2 = new JCheckBox("Blue");
        c3 = new JCheckBox("Black");

        ButtonGroup bg = new ButtonGroup();
        bg.add(r1);
        bg.add(r2);
        bg.add(r3);

        add(b1);
        add(b2);
        add(b3);
        add(b4);
        add(r1);
        add(r2);
        add(r3);
        add(c1);
        add(c2);
        add(c3);

        b1.addActionListener(this);
        b2.addActionListener(this);
        b3.addActionListener(this);
        b4.addActionListener(this);

    }

    public void actionPerformed(ActionEvent ae) {

        
        if (r1.isSelected()) {
            getContentPane().setBackground(Color.GREEN);
        }
        else if (r2.isSelected()) {
            getContentPane().setBackground(Color.BLUE);
        }
        else if (r3.isSelected()) {
            getContentPane().setBackground(Color.BLACK);
        }
        else if(ae.getSource() == b1) {
            getContentPane().setBackground(Color.GREEN);
        }
        else if(ae.getSource() == b2) {
            getContentPane().setBackground(Color.BLUE);
        }
        else if(ae.getSource() == b3) {
            getContentPane().setBackground(Color.BLACK);
        }
        else if(c1.isSelected()) {
            getContentPane().setBackground(Color.GREEN);
        }
        else if(c2.isSelected()) {
            getContentPane().setBackground(Color.BLUE);
        }
        else if(c3.isSelected()) {
            getContentPane().setBackground(Color.BLACK);
        }

    }
}
