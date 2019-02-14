
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
                //bat 'nuget restore "/Source/VS Solution/Desktop Application.sln"'
                bat "msbuild.exe \"${WORKSPACE}\\Source\\VS Solution\\Desktop Application.sln" /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"
            }
        }
    }
}