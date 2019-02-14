
pipeline {
    options {
        buildDiscarder logRotator(numToKeepStr: '3')
    }

    agent any
    
    stages {

        stage("Git Checkout") {
            steps {
                git branch: 'master', credentialsId: 'umairnaushad@gmail.com', url: 'https://github.com/umairnaushad/DotNet.git' 
            }
        }

        stage("Build") {
            steps {
                bat 'nuget restore "/Source/VS Solution/Desktop Application.sln"'
            }
        }
    }
}