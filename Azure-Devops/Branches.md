## Branches

#### Trunk-based branching

----

This is a very simple branching strategy with the following features.
1. Master branch is the central branch. (**Completed work**)
2. Create a **feature branch** from the master for all new features and bug fixes. (**Work in progress**)
3. **Merge** feature branches into the master branch using pull requests. (**Transition from Work in progress to Completed**)
4. Create a **release branch** from the master when you need to release a version of the code. (**Completed work goes to**
**production**)
5. Create a **hotfix branch** from the master to **fix critical production bugs**. Merge the changes back to master, and use **git cherry-pick** command to bring back the changes into the release branch.

![image-20210820214328008](https://github.com/venu-shastri/sapient-dotnet-core-knowledge-repo/blob/main/Azure-Devops/Trunk%20Based%20Branching.png)

      #### Branch Naming Convention

----

- features/feature-id
- users/username/feature-id
- features/feature-name
- bugfix/description
- releases/release-number

> it is quite important that you do not allow the team members directly push their changes to the master branch. Instead, it should be done through pull requests.

> How we can lock the master branch  in Azure DevOps ?



### Git flow

----

- Git flow uses a set of long running branches to represent different stages of the development cycle.
- The **master branch** always contains the **stable code** that is **deployed (or will be deployed) to production**
- In addition to the **master branch**, there is a **parallel branch** called **develop** that is used by developers to
  work from
- Developers can create their **feature branche**s from the **develop branch** . Once the **develop branch** comes to a **stable point**, Developers  can **merge it to the master branch** for the next release . This can be done through a **release**
  **branch** and the **bug fixing** on the **release branch** has to be continuously **merged back into the develop branch**
- Once Developers satisfied with the **release branch**, you can **merge it to the master branch for the next release**
- **Hotfixes** to the **current version** can be done on a **hotfix branch** from master and **merged back to both master and develop.**

![image-20210820220241415](E:\Azure-Devops\Git Based Flow)

As explained in the previous section, you can use **pull requests to merge changes to develop, release and master branches.**



### Tags

----

Git tags are used to mark a specific commit as an important point in the history



### Pull requests

---

Pull requests is a very good way of maintaining a high quality in code. This allows team members  to discuss, review and quality assure  code changes before they get merged into your base branch.

