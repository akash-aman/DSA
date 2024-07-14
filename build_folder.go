package main

import (
	"flag"
	"fmt"
	"os"
	"os/exec"
	"path/filepath"
)

type Command struct {
	relativePath string
	cmdName      string
	cmdArgs      []string
}

func init() {
	ds := flag.String("ds", "", "Data Structure Folder Name")

	pb := flag.String("pb", "", "Problem Folder Name")

	flag.Parse()

	if "" == *ds || "" == *pb {
		fmt.Printf("⚠️ folder name not provided \n")
		return
	}

	cmds := []Command{
		{
			relativePath: *ds + "/" + *pb + "/" + "go",
			cmdName:      "go",
			cmdArgs:      []string{"mod", "init", *pb},
		},
		{
			relativePath: *ds + "/" + *pb + "/" + "go",
			cmdName:      "touch",
			cmdArgs:      []string{"main.go"},
		},
		{
			relativePath: *ds + "/" + *pb + "/" + "cs",
			cmdName:      "dotnet",
			cmdArgs:      []string{"new", "console"},
		},
		{
			relativePath: *ds + "/" + *pb + "/" + "js",
			cmdName:      "touch",
			cmdArgs:      []string{*pb + ".js"},
		},
		{
			relativePath: *ds + "/" + *pb + "/" + "py",
			cmdName:      "touch",
			cmdArgs:      []string{*pb + ".py"},
		},
		{
			relativePath: *ds + "/" + *pb + "/" + "ts",
			cmdName:      "touch",
			cmdArgs:      []string{*pb + ".ts"},
		},
	}

	for _, cmd := range cmds {
		runShellCommand(cmd.relativePath, cmd.cmdName, cmd.cmdArgs)
	}

}

func createFolder(folderPath string) {

	err := os.MkdirAll(folderPath, os.ModePerm)

	if err != nil {
		fmt.Printf("Issue with creating folder")
	}
}

func runShellCommand(relativePath string, cmdName string, cmdArgs []string) {
	currentDir, _ := os.Getwd()
	folderPath := filepath.Join(currentDir,relativePath)

	createFolder(folderPath)

	cmd := exec.Command(cmdName, cmdArgs...)
	cmd.Dir = folderPath

	opt, err := cmd.CombinedOutput()

	if err != nil {
		fmt.Printf("Error executing command : %s \n", err)
	}

	fmt.Printf("output: %s", opt)
}

func main() {}
