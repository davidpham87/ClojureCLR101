(let [root "/home/david/Documents/playground/dotnet/bin/Debug/net5.0/"]
  (assembly-load-file (str root "myApp.dll")))

(ns hello
  (:require [clojure.string :as str])
  (:import System.Environment
           (myApp Program Point Person)))

(str/split-lines "a\nb")

(.Show (myApp.Point. 3 3))
(.Show (myApp.Point. 50 1))
myApp.Person/age
(* 10 (.SuperAge (myApp.Person.)))

;; myApp.Person/name
;; myApp.Person/age

(comment
  #_(myApp.Program/Main)
  (.. System.Environment (GetEnvironmentVariable "CLOJURE_LOAD_PATH"))
  (* 3 5))
