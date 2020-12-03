690. Employee Importance

/*
// Definition for Employee.
class Employee {
    public int id;
    public int importance;
    public IList<int> subordinates;
}
*/

class Solution {
    public int GetImportance(IList<Employee> employees, int id) {
        
        int totalImportance = 0;
        Dictionary<int, Employee> employeeMap = new Dictionary<int, Employee>();
        
        foreach(var emp in employees){
            employeeMap.Add(emp.id, emp);
        }
        
        Queue<Employee> queue = new Queue<Employee>();
        queue.Enqueue(employeeMap[id]);
        
        while(queue.Count > 0){
           
            var currentEmp = queue.Dequeue();
            totalImportance += currentEmp.importance;
            
            foreach(var subordinate in currentEmp.subordinates){
                if(employeeMap.ContainsKey(subordinate))
                    queue.Enqueue(employeeMap[subordinate]);
            }
            
        }
        
        return totalImportance;
    }
}
