1. Git Basic commands
 * git config --global user.name "mallabonikki"
 * git config --global user.email "mallabonikki6678@gmail.com"
 * git config --list
 * git config --help
 * git help config
 * git add --help
 
 * git init

 * Multiply query parameters and View it as ViewContent 
 * git status
 * git diff
 * git add -A = add to staging area
 * git reset = unstage all files that has been in stage area previously
 * git commit -m "Multiply query parameters and View it as ViewContent"
 * git branch -a
 * git remote add origin <url>
 * git pull origin master
 * git push origin master
 * git branch -a

2. Common Workflow
 * Create a branch for the desired feature
 * git branch calc-divide
 * git branch
 * git checkout calc-divide
 * git branch
 * Create ContentResult that can divides two numbers and view it as ViewContent
 * git status
 * git add -A
 * git commit -m "Divide ContentResult
 * git push -u origin calc-divide
 * git branch -a = to list all the branches
 * git checkout master = switched to master branch
 * git pull origin master = before commit anything to master it needs to pull out all changes from remote repository
 * git branch --merged = list all branch that has been merged
 * git merge calc-divide = it will merge all the changes in the master
 * git push origin master
 * git branch --merged = check if it is successfully merged
 * git branch -d calc-divide = calc-divide local repository should be disappeared
 * git branch -a = calc-divide branch should be disappeared
 * git push origin --delete calc-divide
 * git branch -a = calc-divide remote repository should be deleted
 
3. Fixing Common Mistakes and Undoing Bad Commits
 * branch is on master
 * create this guy: public ContentResult Subract(int a, int b)
                    {
                        return Content("");
                    }
 * git add -A
 * git commit -m "Initial Subract"
 * git status = Working tree clean
 * git log = Intial Subract (is the current HEAD)
 * git branch subract-feature = create new branch called subract-feature
 * modify this guy on the master branch: 
   public ContentResult Subract(int a, int b)
   {
       return Content("This is and example string asdfasdfasdfdfasdf");
   }
 * git status = HomeContrller was modified
 * git diff = It shows the changes that was made in the HomeContrller
 * git checkout Git-basics/Controllers/HomeController.cs = working tree should be clean
 * git diff = no changes
 * go back to the file and reload, the file back to the way the things were after we made the Inital Subract commit, the working tree        will be cleaned
 * modify to: public ContentResult Subract(int a, int b)
              {
                  return Content(string.Format("{0}", a - b));
              }
 * git add -A,
 * git commit -m "Completed Multiply Function" = This is a wrong message. I intentionally did it.
 * git log
 * git commit --amend -m "Completed Subract Function" = use --amend option to change the commit messaage from the last commit, However      the hash value has changed
 
 * modify the .gitignore file
 * git add .gitignore
 * git log -stat = 1 file changed HomeController.cs
 * git commit --amend = no messaage
   editor will pop up the press ":wq" to save and exit
 * git log
 * git log --stat = 2 files changed HomeController.cs and .gitignore(will show this log)



 
  
  


 
  
