def tagName

pipeline {

    options {
        buildDiscarder logRotator(numToKeepStr: '3')
    }

    agent any

    stages {
        stage("Pipeline Info") {
            steps {
                script {
                    tagName=env.BRANCH_NAME
                    echo 'BRANCH_NAME: ' + ${tagName}
                    echo sh(returnStdout: true, script: 'env')
                }                
            }
        }
    }
}