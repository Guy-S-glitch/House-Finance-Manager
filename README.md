# House Finance Manager

this is my first project using WINFORMS in c#, about managing a family's finance. the project's main idea is to build a virtual house that will illustrate a real-life house, you will be able to create the people in the house, insert needed information and the project will give the user relative output like income, expenses, useful diagrams etc.

# data flow
the project's work is based mainly on the user's input
<ol>
  <li> wanted house is pressed</li>
  <li> in the house there is 3 options
    <ul>
      <li> Add member</li>
      <li> Remove member</li>
      <li> Inspect member</li>
    </ul>
  </li>
  <li> clicking the "Add member" option will open another form that will ask the user for the data about the member he wants to add to the house</li>
  <li> Clicking the "Remove member" option will remove a selected member from the house </li>
  <li> Clicing the "Inspect member" option will see the data about a selected member</li>
  <li> once the user will decide to close the house form the data will be stored at the wanted house he pressed at the beginning</li>
  <li> the flow start over from step 1 but now there will be exist members at the house</li>
</ol>

# MSSQL
## Execute the next query scripts in your new created database:
"INSERT INTO [dbo].[Houses] ([HouseNumber], [memberName], [Birth], [Gender], [Picture], [Job], [Experience], [Salary], [City], [Phone], [Email], [Transport], [Clothes], [Sport], [Market], [Utilities], [Rent], [Restaurant])VALUES ('House1', 'Yossi Bar Moshe', '2000-03-03', 'Male', File.ReadAllBytes(@"path of photo"), 'Unemployed', 0, 0, 'Ashdod', '0505550000', 'asdd@asdq.qwd', 1, 1, 1, 1, 1, 1, 1)"
