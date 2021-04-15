import java.sql.*;

public class tmsinfo {
    
    int id;
    String date;
    String type;
    int amount;
    int number;
    String served_by;
}

class tmsinfoDAO
{
    Connection con;
    PreparedStatement ps;
    Statement st;
    ResultSet rs;
    String URL="jdbc:mysql://localhost:3306/tms";
    void Connection()
    {
        try{
          Class.forName("com.mysql.jdbc.Driver");
          con=DriverManager.getConnection(URL,"root","");
          st=con.createStatement();
                
      }catch(Exception ex){
       
      }
    }
    
    int Insert (tmsinfo a)
    {
        int res = 0;
        Connection();
            try{
          String q="INSERT INTO server VALUES (?,?,?,?,?,?)";
          ps=con.prepareStatement(q);
          ps.setInt(1,a.id);
          ps.setString(2,a.date);
          ps.setString(3,a.type);
          ps.setInt(4,a.amount);
          ps.setInt(5,a.number);
          ps.setString(6,a.served_by);
       
          res =  ps.executeUpdate();
          
      }catch(Exception ex){
       
      }
        
        return res;
    }
    
    int Update (tmsinfo a)
    {
        int res = 0;
        Connection();
        
        try{    
          String q="UPDATE server SET date=?,type=?,amount=?,number=?,served_by=? WHERE id=?";
          ps=con.prepareStatement(q);
          
          ps.setString(1,a.date);
          ps.setString(2,a.type);
          ps.setInt(3,a.amount);
          ps.setInt(4,a.number);
          ps.setString(5,a.served_by);
          ps.setInt(6,a.id);
          res =  ps.executeUpdate();
      }
        catch(Exception ex){
          
      }
        return res;
    }
    
    int Delete (tmsinfo a)
    {
        int res = 0;
        Connection();
        
        try{    
          String q="DELETE FROM server WHERE id=?";
          ps=con.prepareStatement(q);
          ps.setInt(1,a.id);
          res =  ps.executeUpdate();
      }
        catch(Exception ex){
          
      }
        return res;
    }
    
    
    ResultSet Select(tmsinfo c)
    {
        ResultSet a = null;
        try
        {
            Connection();
            String q = "SELECT * FROM server WHERE id = ? ";
            ps=con.prepareStatement(q);
            ps.setInt(1,c.id);
            a = ps.executeQuery();
        }
        catch(Exception ex){
          
      }
        return a; 
    }

    

}