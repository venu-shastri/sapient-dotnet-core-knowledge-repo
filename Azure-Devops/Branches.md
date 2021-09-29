

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

![image-20210820214328008](E:\Azure-Devops\Trunk Based Branching)

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

Pull requests is a very good way of maintaining a high quality in code. This allows team members  to discuss, review and quality assure  code changes before they get merged into your base branch. Pull requests functionality can be enabled to branches by setting branch policies.

Open branch policies page for the master

![](E:\sapient-dotnet-core-knowledge-repo\Azure-Devops\Branch Policy.png)



Here, you can add some restrictions and checks before a certain pull request
can be accepted. For example,

1. Specify the number of reviewers who will review the code. You
can also add an automatic code reviewer.
2. The application has to be built successfully in order to complete
the pull request.
3. At least one work item has to be linked to the pull request.

![](E:\sapient-dotnet-core-knowledge-repo\Azure-Devops\Branch Policy2.png)



#### Azure Pipelines

-----

**CI (Continuous Integration)**

----

Build pipeline (CI pipeline) allows you to automate the build and test process of your application. You can setup a build pipeline so that it builds and tests the application code each time a developer commits a change to the source code.

There are basically two ways you can start creating a build pipeline

Method : 1 Navigate to your repository by clicking on Repos and click on the **Set up build button**. In this option, you can skip the selection of the source code location as you are already inside the repository.



![](E:\sapient-dotnet-core-knowledge-repo\Azure-Devops\Build Pipeline 1.JPG)

Method 2: Click on the menu item **Pipelines** on the left-hand side and then click on the **button Create Pipeline.**

![](E:\sapient-dotnet-core-knowledge-repo\Azure-Devops\Build Pipeline 2.JPG)

If you choose Method 2, you have to specify where your source code resides. In this example, our source code resides in Azure Repos Git. Therefore, select Azure Repos Git (YAML) option as shown in Figure

![](E:\sapient-dotnet-core-knowledge-repo\Azure-Devops\Build Pipeline 3.JPG)



Next, you select your code repository. Select  ****** <Repository> 

![](E:\sapient-dotnet-core-knowledge-repo\Azure-Devops\Build Pipeline 4.JPG)



Then you can configure your pipeline to match the technology you have selected to build your application 

![](E:\sapient-dotnet-core-knowledge-repo\Azure-Devops\BuildPipeline5.JPG)

Based on this selection, Azure pipelines creates a basic starting pipeline definition in YAML .

![Review](E:\sapient-dotnet-core-knowledge-repo\Azure-Devops\Build Pipeline 6.JPG)





![](E:\sapient-dotnet-core-knowledge-repo\Azure-Devops\Build Pipeline 7.JPG)

![](E:\sapient-dotnet-core-knowledge-repo\Azure-Devops\Build Pipeline 8.JPG)



#### Introduction to YAML,

-----

YAML (YAML Ain’t Markup Language) is a data serialization language that is used by Azure pipelines to describe different commands in the pipeline. The language is quite similar to JSON (JavaScript Object Notation) and represented in key value pairs  difference is that when writing YAML use spaces for indentation.  Two space indentation is recommended . YAML files have the extension “.yaml” or “.yml”



![](E:\sapient-dotnet-core-knowledge-repo\Azure-Devops\Yaml.JPG)

key: value pairs are the basic building blocks. value can come in different types. For example object, array, string, numbers, Boolean etc..

```yaml
# Starter pipeline
# Start with a minimal pipeline that you can customize to build and deploy your code.
# Add steps that build, run tests, deploy, and more:
# https://aka.ms/yaml
# - = item in an array
# | = preserve the formatting exactly as it is

trigger:
- main

pool:
  vmImage: ubuntu-latest

steps:
- script: echo Hello, world!
  displayName: 'Run a one-line script'

- script: |
    echo Add other tasks to build, test, and deploy your project.
    echo See https://aka.ms/yaml
  displayName: 'Run a multi-line script'
- task: DotNetCoreCLI@2
  inputs:
    command: 'build'
    projects: '**/*.csproj'


/*
trigger:
- master
According to what we have learned; this represents an array. In other words, an array of triggers. Basically, we want to trigger our build pipeline each time a developer checks in new code changes to the master branch. Assume, you want to run the build pipeline on all the release branches located under the
releases folder, then you can modify this as follows.
trigger:
- master
- releases/*
If you want the build pipeline to kick off on every commit in every branch, then you can set it as follows.
trigger:
- '*'

pool:
vmImage: 'ubuntu-latest'
In this command, it specifies a Microsoft-hosted agent pool. In Azure Pipelines, the name of this pool is Azure Pipelines. An agent pool is used to organize build agents.A build agent can be considered as the heart of the build pipeline, which performs all the jobs defined in the build pipeline. In an Azure DevOps
services context, it is an installable software, which is hosted in a virtual machine.
As you can see, the pool object contains the vmImage property which contains the value ‘ubuntu-latest’. This means that we want to run our build pipeline in a build agent hosted in an Ubuntu virtual machine. Azure
pipelines hosted pool gives you the option to select from several virtual machine images.

Virtual machine											 	image YAML label
Windows Server 2019 with Visual Studio 2019					windows-latest OR windows-2019
Windows Server 2016 with VisualStudio 2017					vs2017-win2016
Ubuntu 18.04 												ubuntu-latest OR ubuntu-18.04                  Ubuntu 16.04												   ubuntu-16.04
macOS X Mojave 10.14 										macOS-latest OR macOS-10.14

The next set of commands define a job containing a series of steps performed by the agent. These steps are all about building the application

steps:
- script: echo Hello, world!
  displayName: 'Run a one-line script'

- script: |
    echo Add other tasks to build, test, and deploy your project.
    echo See https://aka.ms/yaml
  displayName: 'Run a multi-line script'
- task: DotNetCoreCLI@2
  inputs:
    command: 'build'
    projects: '**/*.csproj'
    

```

