
pipeline {
    agent any
    
    stages {
        stage("Stage 1") {
            steps {
                echo "Testing Stage 1"                
            }
        }

        stage("Git Checkout") {
            steps {
                git branch: 'master', credentialsId: 'umairnaushad@gmail.com', url: 'https://github.com/umairnaushad/DotNet.git' 
            }
            
            //git credentialsId: '024bccc0-b60c-4b11-a116-f34ce28bd470', url: 'https://github.com/umairnaushad/DotNet.git'
        }
    }
}